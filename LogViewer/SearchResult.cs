using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LogViewer
{
    public class SearchResult
    {
        public int PageNo { get; set; }
        public int Index { get; set; }
        public int Length { get; set; }
        public string Sample { get; set; }

        public override string ToString()
        {
            return string.Format("PageNo: {0}, Index: {1}, Sample: {2}", PageNo, Index, Sample);
        }
    }
}
