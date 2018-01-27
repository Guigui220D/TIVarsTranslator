using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TIVarsTranslators
{
    static class ByteUtils
    {
        const byte L_MASK = 0xF0;
        const byte R_MASK = 0x0F;
        const string DIGITS = "0123456789";

        public static byte GetLeftHalf(byte b)
        {
            return (byte)((byte)(b & L_MASK) / R_MASK);
        }

        public static byte GetRightHalf(byte b)
        {
            return (byte)(b & R_MASK);
        }

        public static char GetMantissaDigit(byte code)
        {
            if (code <= 9)
                return DIGITS[code];
            return '0';
        }

        public static bool GetBitInByte(byte b, byte pos)
        {
            if (pos > 7)
                return false;
            pos = (byte)Math.Pow(2, pos);
            byte r = (byte)(b & pos);
            r /= pos;
            return r == 1;
        }
    }
}
