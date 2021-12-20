using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BEL
{
    public class CartModel
    {
        public int Id { get; set; }
        public string ShopName { get; set; }
        public Nullable<int> BookId { get; set; }
        public string BookName { get; set; }
        public Nullable<double> UnitPrice { get; set; }
        public Nullable<int> Quantity { get; set; }
        public string CustomerName { get; set; }
    }
}
