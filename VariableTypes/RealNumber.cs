using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TIVarsTranslators.Types
{
    public class TIRealNumber : TIVar
    {
        private readonly byte[] mantissa = new byte[7];
        private byte exponent;
        public bool isUndefined;
        public bool isHalfOfAComplex;
        public bool isUncertain;
        public bool isNegative;

        public void SetFlags(byte flag)
        {
            isUndefined = ByteUtils.GetBitInByte(flag, 1);
            isHalfOfAComplex = ByteUtils.GetBitInByte(flag, 2) && ByteUtils.GetBitInByte(flag, 3) && !ByteUtils.GetBitInByte(flag, 1);
            isUncertain = ByteUtils.GetBitInByte(flag, 6);
            isNegative = ByteUtils.GetBitInByte(flag, 2);
        }
        public byte GetFlag()
        {
            byte flag = 0x00;
            if (isUndefined)
                flag += 0x02;
            if (isHalfOfAComplex && !isUndefined)
                flag += 0x0C;
            if (isUncertain)
                flag += 0x40;
            if (isNegative)
                flag += 0x80;
            return flag;
        }

        public byte[] GetMantissa()
        {
            return mantissa;
        }

        public override byte[] GetData()
        {
            List<byte> data = new List<byte>();
            data.Add(GetFlag());
            data.Add(exponent);
            for (int i = 0; i < 7; i++)
                data.Add(mantissa[i]);
            return data.ToArray();
        }
        public override TIVarTypes GetTIType()
        {
            return TIVarTypes.RealNumber;
        }
        public override string GetCorrespondingExtension()
        {
            return ".8Xn";
        }

        public TIRealNumber(bool undefined = true)
        {
            exponent = 0x80;
            isUndefined = undefined;
        }
        public TIRealNumber(decimal value)
        {
            string asText = value.ToString().Replace(",", "").Replace("-", "");
            asText = asText.PadRight(14, '0');
            for (int i = 0; i < 7; i++)
            {
                mantissa[i] = (byte)(byte.Parse(asText[i * 2 + 1].ToString()) + (byte.Parse(asText[i * 2].ToString()) * 16));
            }
            if (value < 0)
                isNegative = true;
            int j = -127;
            while (Math.Pow(10, j) <= Math.Abs((double)value))
                j++;
            if (Math.Abs(value) < 1)
                j++;
            exponent = (byte)(j + 127);
        }

        public decimal ToDecimal()
        {
            if (isUndefined)
                return 0;

            string digits = "";
            for (int i = 0; i < 7; i++)
            {
                digits += ByteUtils.GetMantissaDigit(ByteUtils.GetLeftHalf(mantissa[i]));
                digits += ByteUtils.GetMantissaDigit(ByteUtils.GetRightHalf(mantissa[i]));
            }
            decimal part = long.Parse(digits);

            part /= 10000000000000;
            part *= (decimal)Math.Pow(10, ((int)exponent) - 128);

            if (isNegative)
                part = -part;

            return part;
        }
        public override string ToString()
        {
            if (isUndefined)
                return "Undefined";
            return ToDecimal().ToString();
        }
    }
}
