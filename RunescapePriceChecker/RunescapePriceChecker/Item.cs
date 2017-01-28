using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RunescapePriceChecker
{
    public class Item
    {
        public string overall { get; set; }
        public string buying { get; set; }
        public string buyingQuantity { get; set; }
        public string selling { get; set; }
        public string sellingQuantity { get; set; }

        public Item()
        {
            this.overall = "";
            this.buying = "";
            this.buyingQuantity = "";
            this.selling = "";
            this.sellingQuantity = "";
        }

        public Item(string o, string b, string bq, string s, string sq)
        {
            this.overall = o;
            this.buying = b;
            this.buyingQuantity = bq;
            this.selling = s;
            this.sellingQuantity = sq;
        }
    }
}
