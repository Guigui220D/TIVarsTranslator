using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TIVarsTranslators.Types
{
    public class TIMatrix : TIVar
    {
        public TIRealNumber[,] numbers;

        public override byte[] GetData()
        {
            List<byte> data = new List<byte>();
            byte a = (byte)numbers.GetLength(0);
            byte b = (byte)numbers.GetLength(1);
            data.Add(a);
            data.Add(b);
            for (int y = 0; y < numbers.GetLength(1); y++)
            {
                for (int x = 0; x < numbers.GetLength(0); x++)
                {
                    byte[] d = numbers[x, y].GetData();
                    for (int i = 0; i < d.Length; i++)
                        data.Add(d[i]);
                }
            }
            return data.ToArray();
        }

        public void SetValue(byte x, byte y, TIRealNumber n)
        {
            numbers[x, y] = n;
        }

        public TIMatrix(byte width, byte height)
        {
            numbers = new TIRealNumber[width, height];
        }

        public override TIVarTypes GetTIType()
        {
            return TIVarTypes.Matrix;
        }
        public override string GetCorrespondingExtension()
        {
            return ".8Xm";
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
