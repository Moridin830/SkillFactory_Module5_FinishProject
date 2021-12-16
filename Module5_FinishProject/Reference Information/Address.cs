using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module5_FinishProject.Reference_Information
{
    internal class Address
    {
        public string PostalCode
        {
            get 
            {
                return PostalCode;
            } 
            set
            {
                if(value.Length == 6)
                {
                    PostalCode = value;
                }
                else
                {
                    Console.WriteLine("Incorrect code entered.");
                }
            }
        }
        public string Country;
        public string StateProvince;
        public string City;
        public string AddressString; 
    }
}
