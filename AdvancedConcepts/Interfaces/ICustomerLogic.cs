using AdvancedConcepts.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedConcepts.Interfaces
{

    public interface ICustomer
    {
        int AddNewCustomer(Customer newCustomer);
        List<Customer> GetCustomers();
        Customer GetCustomer(int customerID);
    }
}
