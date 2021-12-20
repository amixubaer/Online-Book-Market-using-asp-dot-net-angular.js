using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BEL
{
    public class OrderDetailModel
    {
        public int Id { get; set; }
        public Nullable<int> OrderId { get; set; }
        public string ShopName { get; set; }
        public Nullable<int> BookId { get; set; }
        public string BookName { get; set; }
        public Nullable<double> UnitPrice { get; set; }
        public Nullable<int> Quantity { get; set; }
        public string Status { get; set; }
    }
}
