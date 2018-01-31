using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TIVarsTranslators.Types
{
    public class TIString : TITokenString
    {
        public override string GetCorrespondingExtension()
        {
            return ".8Xs";
        }

        public override TIVarTypes GetTIType()
        {
            return TIVarTypes.String;
        }

        public TIString()
        {

        }
    }
}
