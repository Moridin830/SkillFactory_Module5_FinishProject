using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module5_FinishProject
{
    /// <summary>
    /// Класс для описания покупателя типа "Физическое лицо" 
    /// </summary>
    internal class Client : Person
    {
        public Reference_Information.Address DeliveryAddress;
    }
}
