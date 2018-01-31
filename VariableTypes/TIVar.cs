using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TIVarsTranslators.Types
{
    public abstract class TIVar
    {
        public abstract byte[] GetData();
        public abstract TIVarTypes GetTIType();
        public abstract string GetCorrespondingExtension();
    }

    public enum TIVarTypes : byte
    {
        RealNumber = 0x00,
        RealList = 0x01,
        Matrix = 0x02,
        YVariable = 0x03,
        String = 0x04,
        Program = 0x05,
        Picture = 0x07,
        WindowSettings = 0x0B,
        ComplexNumber = 0x0C,
        TableSetup = 0x10,
    }
}
