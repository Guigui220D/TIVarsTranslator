using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TIVarsTranslators.Types
{
    public class TIRealList : TIVar
    {
        public List<TIRealNumber> numbers;

        public override byte[] GetData()
        {
            List<byte> data = new List<byte>();
            int length = numbers.Count;
            byte a = (byte)(length & 0x00FF);
            byte b = (byte)((length & 0xFF00) / 0xFF);
            data.Add(a);
            data.Add(b);
            foreach (TIRealNumber rn in numbers)
            {
                byte[] d = rn.GetData();
                for (int i = 0; i < d.Length; i++)
                    data.Add(d[i]);
            }
            return data.ToArray();
        }

        public void AddNumber(TIRealNumber number)
        {
            numbers.Add(number);
        }

        public TIRealList()
        {
            numbers = new List<TIRealNumber>();
        }

        public override TIVarTypes GetTIType()
        {
            return TIVarTypes.RealList;
        }
        public override string GetCorrespondingExtension()
        {
            return ".8Xl";
        }

        public override string ToString()
        {
            string r = "[";
            foreach (TIRealNumber n in numbers)
            {
                r += n.ToString() + "; ";
            }
            r += ']';
            return r;
        }
    }
}
