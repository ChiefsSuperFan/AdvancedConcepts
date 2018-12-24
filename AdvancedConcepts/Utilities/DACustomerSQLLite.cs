using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdvancedConcepts.Interfaces;
using AdvancedConcepts.Classes;

namespace AdvancedConcepts.Utilities
{
    class DACustomerSQLLite : IDACustomer
    {
        //data access class exclusively for SQLLite

        public DACustomerSQLLite()
        {

        }

     
        public List<Customer> GetAllRecords()
        {
            List<Customer> customers = new List<Customer>();
            return customers;
        }

        public bool UpdateRecord(Customer selectedRecord)
        {
            return true;
        }

        public bool DeleteRecord(Customer selectedRecord)
        {
            return true;
        }

        public int AddRecord(Customer newRecord)
        {
            //adds new record and returns its id
            return 1;

        }
    }
}
