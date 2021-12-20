using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BEL
{
    public class StatementModel
    {
        public int Id { get; set; }
        public Nullable<System.DateTime> Date { get; set; }
        public string Expenditure { get; set; }
        public Nullable<double> Amount { get; set; }
    }
}
