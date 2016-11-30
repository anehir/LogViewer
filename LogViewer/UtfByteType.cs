using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LogViewer
{
    public enum UtfByteType
    {
        SingleByte = 0,
        LeadingOfTwo,
        LeadingOfThree,
        LeadingOfFour,
        Trailing
    }
}
