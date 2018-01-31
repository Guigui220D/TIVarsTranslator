using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TIVarsTranslators.Types
{
    public class TITestProgram : TITokenString
    {
        public override string GetCorrespondingExtension()
        {
            return ".8Xp";
        }

        public override TIVarTypes GetTIType()
        {
            return TIVarTypes.Program;
        }

        public TITestProgram()
        {
            tokens.Add(0xDE);
            tokens.Add(0x2A);
            tokens.Add(0x49);
            tokens.Add(0x54);
            tokens.Add(0x29);
            tokens.Add(0x57);
            tokens.Add(0x4F);
            tokens.Add(0x52);
            tokens.Add(0x4B);
            tokens.Add(0x53);
            tokens.Add(0x2A);
        }
    }
}
