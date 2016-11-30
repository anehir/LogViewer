using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LogViewer
{
    internal class ByteFilter
    {
        public byte Filter { get; set; }
        public byte Beginning { get; set; }

        public ByteFilter(string filter, string beginning)
        {
            this.Filter = (byte)Convert.ToInt32(filter, 2);
            this.Beginning = (byte)Convert.ToInt32(beginning, 2);
        }

    }
}
