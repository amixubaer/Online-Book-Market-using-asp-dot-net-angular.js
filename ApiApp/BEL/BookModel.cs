using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BEL
{
    public class BookModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string Publisher { get; set; }
        public string Edition { get; set; }
        public Nullable<double> Price { get; set; }
        public string ShopName { get; set; }
        public Nullable<int> Quantity { get; set; }
        public string Thumbnail { get; set; }
    }
}
