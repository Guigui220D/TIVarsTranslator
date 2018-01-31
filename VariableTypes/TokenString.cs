using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TIVarsTranslators.Types
{
    public abstract class TITokenString : TIVar
    {
        public List<byte> tokens = new List<byte>();

        private byte[] GetTokensLenght()
        {
            int length = tokens.Count;
            byte a = (byte)(length & 0x00FF);
            byte b = (byte)((length & 0xFF00) / 0xFF);
            return new byte[] { a, b };
        }

        public override byte[] GetData()
        {
            List<byte> data = new List<byte>();
            byte[] lenght = GetTokensLenght();
            data.Add(lenght[0]);
            data.Add(lenght[1]);
            foreach (byte b in tokens)
                data.Add(b);
            return data.ToArray();
        }        
    }
}
