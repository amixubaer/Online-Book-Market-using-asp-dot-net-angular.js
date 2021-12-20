using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BEL
{
    public class BookShopModel
    {
        public BookShopModel()
        {
            this.book = new BookModel();
        }
        public string Uname { get; set; }

        public virtual BookModel book { get; set; }
    }
}
