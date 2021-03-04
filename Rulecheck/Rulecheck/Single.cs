using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rulecheck
{
    class Single
    {

        public int idProduct;
        public int idMetaproduct;
        public string enName;
        public string website;
        public string image;
        public string gameName;
        public string categoryName;
        public string number;
        public string rarity;
        public string expansionName;

        public Single(int idProd, int idMetaProd, string eName, string site, string img, string gName, string cName, string num, string rare, string exName)
        {
            idProduct = idProd;
            idMetaproduct = idMetaProd;
            enName = eName;
            website = site;
            image = img;
            gameName = gName;
            categoryName = cName;
            number = num;
            rarity = rare;
            expansionName = exName;
        }

    }
}
