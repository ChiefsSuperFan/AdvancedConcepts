using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedConcepts.Classes
{
    public class Customer
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public String City { get; set; }
        public USStateCodes State { get; set; }
        public string ZipCode { get; set; }




    }

    public enum USStateCodes
    {
        AL,
        AK,
        AZ,
        AR,
        CA,
        CO
    }
}
