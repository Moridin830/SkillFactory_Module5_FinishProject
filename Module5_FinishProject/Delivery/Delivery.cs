using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module5_FinishProject
{
    /// <summary>
    /// Абстрактный класс для описания типов доставки
    /// </summary>
    /// <typeparam name="TCustomer"></typeparam>
    internal abstract class Delivery<TCustomer>
    {
        public Reference_Information.Address Address;
 
    }
}
