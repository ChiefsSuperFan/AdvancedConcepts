using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdvancedConcepts.BusinessLayer;
using AdvancedConcepts.Interfaces;
using AdvancedConcepts.Utilities;

namespace AdvancedConcepts.DI
{
   
   
    public class DIContainer
    {
        readonly private int _currentUserID = 0;

        //depdency objects
        private IDACustomer _daCustomer;
        private ISymmEncryption _symmEncryption;

        private ICustomer _customer;

        

        public DIContainer(int currentUserID)
        {
            _currentUserID = currentUserID;
            InitializeDependencies();

        }
       

        public object Resolve<T>()
        {
            Type type = typeof(T);

            string className = type.Name;

            switch(className)
            {
                case "BLCustomer":
                    if(_customer==null)
                    {
                        _customer = new BLCustomer(_symmEncryption, _daCustomer, _currentUserID);
                    }

                    return _customer;
                   
            }
            return _customer;
        }



        private void InitializeDependencies()
        {
            _daCustomer = new DACustomerSQLLite();
            _symmEncryption = new SymmEncryption();


        }






    }
}
