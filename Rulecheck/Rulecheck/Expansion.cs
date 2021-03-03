using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rulecheck
{
    class Expansion
    {

        public string expansionName;
        public int expansionID;
        public string expansionAbbr;
        public string blockName;
        public string blockAbbr;

        public Expansion(string eName, int eID, string eAbbr, string bName, string bAbbr)
        {
            expansionName = eName;
            expansionID = eID;
            expansionAbbr = eAbbr;
            blockName = bName;
            blockAbbr = bAbbr;
        }

    }
}
