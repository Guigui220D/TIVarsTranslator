using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TIVarsTranslators.Types
{
    public class TIComplexNumber : TIVar
    {
        public TIRealNumber real;
        public TIRealNumber imaginary;

        public override byte[] GetData()
        {
            List<byte> data = new List<byte>();
            real.isHalfOfAComplex = true;
            imaginary.isHalfOfAComplex = true;
            foreach (byte b in real.GetData())
                data.Add(b);
            foreach (byte b in imaginary.GetData())
                data.Add(b);
            return data.ToArray();
        }

        public override TIVarTypes GetTIType()
        {
            return TIVarTypes.ComplexNumber;
        }
        public override string GetCorrespondingExtension()
        {
            return ".8Xc";
        }

        public TIComplexNumber()
        {
            real = new TIRealNumber(false);
            imaginary = new TIRealNumber(false);
        }
        public TIComplexNumber(TIRealNumber real, TIRealNumber imaginary)
        {
            this.real = real;
            this.imaginary = imaginary;
        }

        public override string ToString()
        {
            return "TI Complex : " + real.ToString() + " + " + imaginary.ToString();
        }
    }
}
