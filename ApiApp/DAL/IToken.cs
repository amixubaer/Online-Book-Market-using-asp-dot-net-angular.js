using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{

    public interface IToken<T, Token>
    {
        void Add(T e);

        void Edit(T e);
        void Delete(Token token);
        List<T> GetAll();
        T Get(Token token);

    }
}
