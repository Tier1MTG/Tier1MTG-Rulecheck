using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rulecheck
{
    class Rules
    {

        public string blockTarget;
        public string expTarget;
        public string singleTarget;
        public string enName;
        public string rarity;
        public int value;
        public string valueSelector;
        public string valueModifier;
        public string cardmarketPrice;

        public string rulesObject = "";

        public Rules(string bTarget, string eTarget, string sTarget, string eName, string rare, int val, string valselector, string valmodifier, string cmprice)
        {

            blockTarget = bTarget;
            expTarget = eTarget;
            singleTarget = sTarget;
            enName = eName;
            rarity = rare;
            value = val;
            valueSelector = valselector;
            valueModifier = valmodifier;
            cardmarketPrice = cmprice;

            if (rarity == "")
            {
                rarity = "NaN";
            }

            if (sTarget=="" && eName=="")
            {
                //If empty string, we target ALL singles
                singleTarget = "ALL SINGLES";
                enName = "ALL SINGLES";
            } else
            {
                rarity = "NaN";
            }



            rulesObject += blockTarget;
            rulesObject += " | ";
            rulesObject += expTarget;
            rulesObject += " | ";
            rulesObject += singleTarget;
            rulesObject += " | ";
            rulesObject += enName;
            rulesObject += " | ";
            rulesObject += value;
            //rulesObject += " | ";
            rulesObject += valueSelector;
            rulesObject += " | ";
            rulesObject += valueModifier;
            rulesObject += " | ";
            rulesObject += cardmarketPrice;

        }
        
        /*
        * Functions that passes the rule to the database.
        */
        public void commitToSQL(SQLQuery sql)
        {
            sql.insertRule(blockTarget, expTarget, singleTarget, enName, rarity, value, valueSelector, valueModifier, cardmarketPrice);
        }

    }
}
