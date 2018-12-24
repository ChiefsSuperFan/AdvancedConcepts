using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdvancedConcepts.Classes;
using AdvancedConcepts.Interfaces;

namespace AdvancedConcepts.BusinessLayer
{
   public class BLCustomer : ICustomer
    {
        readonly private ISymmEncryption _encryptor;
        readonly private IDACustomer _dataAccess;
        readonly int _userID = 0;

        public BLCustomer()
        {

        }

        public BLCustomer(ISymmEncryption encryptor, IDACustomer dataAccess, int userID)
        {
            _encryptor = encryptor;
            _dataAccess = dataAccess;
            _userID = userID;
        }

        public int AddNewCustomer(Customer newCustomer)
        {
            //do stuff here encrypting fields and calling data access layer
            return 1;

        }

        public Customer GetCustomer(int customerID)
        {
            Customer customer = new Customer();
            return customer;
        }

        public List<Customer> GetCustomers()
        {
            List<Customer> customers = _dataAccess.GetAllRecords();
            return customers;
        }

     
    }

    

    
}
