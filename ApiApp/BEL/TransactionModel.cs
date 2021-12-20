using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BEL
{
    public class TransactionModel
    {
        public int Id { get; set; }
        public string ShopName { get; set; }
        public string CustomerName { get; set; }
        public Nullable<double> Amount { get; set; }
        public Nullable<System.DateTime> Date { get; set; }
    }
}
