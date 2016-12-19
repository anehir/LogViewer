using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace LogViewer
{
    internal class LogFile : IDisposable
    {
        FileStream fs;
        const int pageSize = 4096;
        byte[] fileBuffer = new byte[pageSize + 5];
        public int PageCount { get; set; }
        bool utf8 = true;

        public bool IsDisposed { get; set; }

        public int CurrentPage
        {
            get { return (int)Math.Ceiling((decimal)fs.Position / pageSize); }
            set
            {
                if (value < 1)
                {
                    value = 1;
                }
                else if (value > this.PageCount)
                {
                    value = this.PageCount;
                }
                var position = (value - 1) * pageSize;
                fs.Seek(position, SeekOrigin.Begin);
            }
        }

        public LogFile(string filePath)
        {
            this.IsDisposed = false;
            fs = File.OpenRead(filePath);
            PageCount = ((int)fs.Length / pageSize) + 1;
        }

        public string ReadOnePage()
        {
            ResetBuffer();
            int count = fs.Read(fileBuffer, 0, pageSize);
            if (utf8 && count == pageSize)
            {
                var utfByte = new UtfByte(fileBuffer[pageSize - 1]);
                int missingCount = 0;
                if (utfByte.UtfByteType == UtfByteType.Trailing)
                {
                    int offset = 1;
                    while ((utfByte = new UtfByte(fileBuffer[pageSize - offset])).UtfByteType == UtfByteType.Trailing)
                    {
                        offset++;
                    }
                    missingCount = utfByte.CharLength - offset;
                }
                else if (utfByte.UtfByteType != UtfByteType.SingleByte)
                {
                    missingCount = utfByte.CharLength - 1;
                }
                if (missingCount > 0)
                {
                    byte[] restOfBytes = new byte[utfByte.CharLength - missingCount];
                    int restOfBytesCount = fs.Read(restOfBytes, 0, restOfBytes.Length);
                    for (int j = 0; j < restOfBytes.Length; j++)
                    {
                        fileBuffer[pageSize + j] = restOfBytes[j];
                    }
                    fs.Seek(fs.Position - restOfBytesCount, SeekOrigin.Begin);
                }
            }
            if (utf8)
            {
                byte[] cleanStart = fileBuffer.SkipWhile(b => new UtfByte(b).UtfByteType == UtfByteType.Trailing).ToArray();
                return System.Text.Encoding.UTF8.GetString(cleanStart).Replace("\r\n", "\n");
            }
            else
            {
                return Encoding.Default.GetString(fileBuffer).Replace("\r\n", "\n");
            }
        }

        private void ResetBuffer()
        {
            for (int i = 0; i < fileBuffer.Length; i++)
            {
                fileBuffer[i] = 0;
            }
        }

        public string ReadPreviousPage()
        {
            this.CurrentPage -= 1;
            return ReadOnePage();
        }

        public string ReadNextPage()
        {
            if (fs.Position < fs.Length)
            {
                return ReadOnePage();
            }
            throw new EndOfStreamException();
        }

        private long FindLastPagesPosition()
        {
            return ((int)(fs.Length / pageSize)) * pageSize;
        }

        public void Dispose()
        {
            this.IsDisposed = true;
            if (fs != null)
            {
                fs.Dispose();
            }
        }

        public List<SearchResult> SearchWithinFile(string pattern, bool useRegex, bool caseSensitive)
        {
            var results = new List<SearchResult>();
            if (string.IsNullOrEmpty(pattern))
            {
                return results;
            }

            var regex = useRegex ? CompileRegex(pattern, caseSensitive) : null;
            int currentPage = this.CurrentPage;
            for (int pageNo = 1; pageNo <= this.PageCount; pageNo++)
            {
                this.CurrentPage = pageNo;
                string page = this.ReadOnePage();
                if (useRegex)
                {
                    var matches = regex.Matches(page);
                    foreach (Match match in matches)
                    {
                        results.Add(new SearchResult() { PageNo = pageNo, Index = match.Index, Length = match.Length, Sample = ExtractSample(page, match.Index, pattern.Length) });
                    }
                }
                else
                {
                    var indices = SearchWithinPage(pattern, page, caseSensitive);
                    foreach (var index in indices)
                    {
                        results.Add(new SearchResult() { PageNo = pageNo, Index = index, Length = pattern.Length, Sample = ExtractSample(page, index, pattern.Length) });
                    }
                }
            }
            return results;
        }

        private static Regex CompileRegex(string pattern, bool caseSensitive)
        {
            Regex regex;
            var regexOptions = RegexOptions.Compiled | RegexOptions.CultureInvariant;
            if (!caseSensitive)
            {
                regexOptions |= RegexOptions.IgnoreCase;
            }
            regex = new Regex(pattern, regexOptions);
            return regex;
        }

        private static List<int> SearchWithinPage(string pattern, string page, bool caseSensitive)
        {
            var indices = new List<int>();
            int index = 0;
            var comparisonType = caseSensitive ? StringComparison.InvariantCulture : StringComparison.InvariantCultureIgnoreCase;
            while (index < page.Length)
            {
                index = page.IndexOf(pattern, index, comparisonType);
                if (index < 0)
                {
                    break;
                }
                else
                {
                    indices.Add(index);
                }
                index += pattern.Length;
            }
            return indices;
        }

        private static string ExtractSample(string page, int index, int patternLength)
        {
            var sampleStart = index - 20;
            if (sampleStart < 0)
            {
                sampleStart = 0;
            }
            var sampleLength = patternLength + 40;
            if (sampleStart + sampleLength > page.Length)
            {
                sampleLength = page.Length - sampleStart;
            }
            return page.Substring(sampleStart, sampleLength);
        }
    }
}
