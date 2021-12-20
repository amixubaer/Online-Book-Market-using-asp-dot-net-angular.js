using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public interface ISalary<T, ID>
    {
        void Add(T e);

        List<T> GetPending();
        List<T> GetApproved();

        void Approve(ID id);
        void Decline(ID id);
    }
}
