using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BEL
{
    public class OrderModel
    {
        public int Id { get; set; }
        public Nullable<double> Amount { get; set; }
        public string CustomerName { get; set; }
        public string Status { get; set; }
    }
}
