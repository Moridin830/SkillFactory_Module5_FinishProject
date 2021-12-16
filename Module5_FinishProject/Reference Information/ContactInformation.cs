using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module5_FinishProject.Reference_Information
{
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
    }
}
