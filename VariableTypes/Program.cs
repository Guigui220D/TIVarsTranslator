using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TIVarsTranslators.Types
{
    public class TIProgram : TITokenString
    {
        public override string GetCorrespondingExtension()
        {
            return ".8Xp";
        }

        public override TIVarTypes GetTIType()
        {
            return TIVarTypes.Program;
        }

        public TIProgram()
        {

        }
    }
}
