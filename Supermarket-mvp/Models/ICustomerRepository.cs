using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermarket_mvp.Models
{
    internal interface ICustomerRepository
    {
        void CustomersAdd(CustomerModel customerModel);
        void CustomersEdit(CustomerModel customerModel);
        void CustomersDelete(int id);
        IEnumerable<CustomerModel> GetAll();
        IEnumerable<CustomerModel> GetByValue(string value);
    }
}
