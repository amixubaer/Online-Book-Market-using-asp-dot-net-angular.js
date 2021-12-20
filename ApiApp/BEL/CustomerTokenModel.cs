using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BEL
{
    public class CustomerTokenModel : CustomerModel
    {
        public List<TokenModel> Tokens { get; set; }
    }
}
