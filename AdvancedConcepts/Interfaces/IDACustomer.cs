using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdvancedConcepts.Classes;

namespace AdvancedConcepts.Interfaces
{
    public interface IDACustomer
    {
        int AddRecord(Customer newRecord);
        bool DeleteRecord(Customer selectedRecord);
        List<Customer> GetAllRecords();
        bool UpdateRecord(Customer selectedRecord);
    }
}
