using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace MyHelpers
{
    public static class ColorHelper
    {
        public static UInt16 ToGBA(this Color c)
        {
            UInt16 ret = 0;

            ret = (UInt16)
                ((( c.B >> 3) << 10)
                | ((c.G >> 3) <<  5)
                | ( c.R >> 3)      );

            return ret;
        }

        public static Color ToColor(this UInt16 us)
        {
            return Color.FromArgb(
                 (us & 0x001F)        << 3,
                ((us & 0x03E0) >>  5) << 3,
                ((us & 0x7C00) >> 10) << 3);
        }

    }
}
