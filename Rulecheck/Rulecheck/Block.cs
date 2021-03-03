using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rulecheck
{
    class Block
    {

        public string blockName;
        public string blockAbbr;
        public Expansion[] expansions = { };

        public Block(string bName, string bAbbr)
        {
            blockName = bName;
            blockAbbr = bAbbr;
        }

        public void addExpansion(Expansion expansion)
        {

            List<Expansion> expansionsList = expansions.ToList();
            expansionsList.Add(expansion);
            expansions = expansionsList.ToArray();

        }

    }
}
