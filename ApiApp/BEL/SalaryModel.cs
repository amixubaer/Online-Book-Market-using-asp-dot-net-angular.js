using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BEL
{
    public class SalaryModel
    {
        public int Id { get; set; }
        public string EmployeeUsername { get; set; }
        public Nullable<double> Salary1 { get; set; }
        public Nullable<double> Bonus { get; set; }
        public string Status { get; set; }
    }
}
