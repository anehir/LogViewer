using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LogViewer
{
    public class UtfByte
    {
        private static readonly ByteFilter single = new ByteFilter("10000000", "00000000");
        private static readonly ByteFilter leadingOfTwo = new ByteFilter("11100000", "11000000");
        private static readonly ByteFilter leadingOfThree = new ByteFilter("11110000", "11100000");
        private static readonly ByteFilter leadingOfFour = new ByteFilter("11111000", "11110000");
        private static readonly ByteFilter trailing = new ByteFilter("11000000", "10000000");

        public UtfByteType UtfByteType { get; private set; }
        public int CharLength { get; private set; }

        public UtfByte(byte utfByte)
        {
            if ((utfByte & single.Filter) == single.Beginning)
            {
                this.UtfByteType = UtfByteType.SingleByte;
                this.CharLength = 1;
            }
            else if ((utfByte & leadingOfTwo.Filter) == leadingOfTwo.Beginning)
            {
                this.UtfByteType = UtfByteType.LeadingOfTwo;
                this.CharLength = 2;
            }
            else if ((utfByte & leadingOfThree.Filter) == leadingOfThree.Beginning)
            {
                this.UtfByteType = UtfByteType.LeadingOfThree;
                this.CharLength = 3;
            }
            else if ((utfByte & leadingOfFour.Filter) == leadingOfFour.Beginning)
            {
                this.UtfByteType = UtfByteType.LeadingOfFour;
                this.CharLength = 4;
            }
            else if ((utfByte & trailing.Filter) == trailing.Beginning)
            {
                this.UtfByteType = UtfByteType.Trailing;
                this.CharLength = -1;
            }
            else
            {
                throw new ArgumentException("This is not a UTF8 byte: " + Convert.ToString(utfByte, 2));
            }
        }

    }
}
