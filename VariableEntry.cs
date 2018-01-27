using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TIVarsTranslators
{
    public class VariableEntry
    {
        private readonly byte[] firstBytes = { 0x0D, 0x00 };
        public readonly byte[] name = new byte[8];
        private byte version = 0;

        public bool isArchived;

        public Types.TIVar variable;

        public int GetLenght()
        {
            return GetIntVarLenght() + 17;
        }
        private byte[] GetVarLength()
        {
            int length = variable.GetData().Length;
            byte a = (byte)(length & 0x00FF);
            byte b = (byte)((length & 0xFF00) / 0xFF);
            return new byte[] { a, b };
        }
        private int GetIntVarLenght()
        {
            return variable.GetData().Length;
        }
        public byte[] GetData()
        {
            List<byte> data = new List<byte>();
            byte[] lenght = GetVarLength();
            data.Add(firstBytes[0]);
            data.Add(firstBytes[1]);
            data.Add(lenght[0]);
            data.Add(lenght[1]);
            data.Add((byte)variable.GetTIType());
            for (int i = 0; i < 8; i++)
                data.Add(name[i]);
            data.Add(version);
            if (isArchived)
            {
                data.Add(0x80);
            }
            else
            {
                data.Add(0x00);
            }
            data.Add(lenght[0]);
            data.Add(lenght[1]);
            byte[] varData = variable.GetData();
            for (int i = 0; i < varData.Length; i++)
                data.Add(varData[i]);
            return data.ToArray();
        }

        public string GetExtension()
        {
            return variable.GetCorrespondingExtension();
        }

        public void SetName(string name)
        {
            byte[] tname = Encoding.ASCII.GetBytes(name);
            for (int i = 0; i < 8; i++)
            {
                if (i < name.Length)
                {
                    this.name[i] = tname[i];
                }
                else
                {
                    this.name[i] = 0;
                }
            }
        }

        public VariableEntry(Types.TIVar var, bool archived = false)
        {
            variable = var;
            name = new byte[] { 0, 0, 0, 0, 0, 0, 0};
            isArchived = archived;
        }
        public VariableEntry(Types.TIVar var, string name, bool archived = false)
        {
            variable = var;
            byte[] tname = Encoding.ASCII.GetBytes(name);
            for (int i = 0; i < 8; i++)
            {
                if (i < name.Length)
                {
                    this.name[i] = tname[i];
                }
                else
                {
                    this.name[i] = 0;
                }
            }
            isArchived = archived;
        }

        public override string ToString()
        {
            return variable.ToString();
        }
    }

}
