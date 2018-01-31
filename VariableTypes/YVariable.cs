using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TIVarsTranslators.Types
{
    public class TIYVariable : TITokenString
    {
        public override string GetCorrespondingExtension()
        {
            return ".8Xy";
        }

        public override TIVarTypes GetTIType()
        {
            return TIVarTypes.YVariable;
        }

        public TIYVariable()
        {

        }
    }
}
