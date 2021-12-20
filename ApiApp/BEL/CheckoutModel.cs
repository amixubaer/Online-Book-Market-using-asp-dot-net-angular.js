using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BEL
{
    public class CheckoutModel
    {
        public CheckoutModel()
        {
            this.Od = new List<BookModel>();
        }
        public string Uname { get; set; }

        public virtual List<BookModel> Od { get; set; }
    }
}
