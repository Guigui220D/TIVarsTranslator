using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace TIVarsTranslators
{
    public class VariableFile
    {
        private readonly byte[] signature = new byte[] { 0x2A, 0x2A, 0x54, 0x49, 0x38, 0x33, 0x46, 0x2A };
        private readonly byte[] fsignature = new byte[] { 0x1A, 0x0A, 0x00 };
        public readonly byte[] comment = new byte[] { 0x47, 0x75, 0x69, 0x67, 0x75, 0x69, 0x32, 0x32, 0x30, 0x44, 0x27, 0x73, 0x20, 0x54, 0x49, 0x20, 0x6C, 0x69, 0x62, 0x72, 0x61, 0x72, 0x79, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 };

        public List<VariableEntry> entries;

        public byte[] CalculateCheckSum()
        {
            long sum = 0;
            foreach (VariableEntry var in entries)
            {
                byte[] data = var.GetData();
                for (int i = 0; i < data.Length; i++)
                    sum += data[i];
            }
            byte a = (byte)(sum & 0x00FF);
            byte b = (byte)((sum & 0xFF00) / 0xFF);
            return new byte[] { a, b };
        }
        private byte[] GetEntryLength()
        {
            int length = 0;
            foreach (VariableEntry var in entries)
            {
                length += var.GetLenght();
            }
            byte a = (byte)(length & 0x00FF);
            byte b = (byte)((length & 0xFF00) / 0xFF);
            return new byte[] { a, b };
        }

        public byte[] GetData()
        {
            List<byte> data = new List<byte>();
            for (int i = 0; i < 8; i++)
                data.Add(signature[i]);
            for (int i = 0; i < 3; i++)
                data.Add(fsignature[i]);
            for (int i = 0; i < 42; i++)
                data.Add(comment[i]);
            byte[] lenght = GetEntryLength();
            data.Add(lenght[0]);
            data.Add(lenght[1]);
            foreach (VariableEntry var in entries)
            {
                byte[] d = var.GetData();
                for (int i = 0; i < d.Length; i++)
                    data.Add(d[i]);
            }
            byte[] checksum = CalculateCheckSum();
            data.Add(checksum[0]);
            data.Add(checksum[1]);
            return data.ToArray();
        }
        
        public VariableFile()
        {
            entries = new List<VariableEntry>();
        }
        public VariableFile(VariableEntry entry)
        {
            entries = new List<VariableEntry>();
            entries.Add(entry);
        }

        public void AddEntry(VariableEntry entry)
        {
            entries.Add(entry);
        }

        public string SuggestExtension()
        {
            if (entries.Count != 1)
                return ".8Xg";
            return entries[0].GetExtension();
        }
    }
}
