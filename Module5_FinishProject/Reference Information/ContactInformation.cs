using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module5_FinishProject.Reference_Information
{
    /// <summary>
    /// Класс для описания контактной информации (организации/отдельного человека)
    /// </summary>
    internal class ContactInformation
    {
        public Address Address { get; set; }
        public string PhoneNumber { get; set; }

        public string EMail
        {
            get
            {
                return EMail;
            }
            set
            {
                if (!value.Contains("@"))
                {
                    Console.WriteLine("E-mail address incorrect.");
                }
            }
        }

        public ContactInformation(Address Address)
        {
            this.Address = Address;
        }

        public ContactInformation(string PhoneNumber, Address Address)
        {
            this.PhoneNumber = PhoneNumber;
            this.Address = Address;
        }

        public ContactInformation(string PhoneNumber, Address Address, string EMail)
        {
            this.PhoneNumber = PhoneNumber;
            this.Address = Address;
            this.EMail = EMail;
        }
    }
}
