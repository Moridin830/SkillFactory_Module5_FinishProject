using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module5_FinishProject
{
    /// <summary>
    /// Класс для описания доставки до пункта выдачи. Доступен для физического лица
    /// </summary>
    internal class PickPointDelivery : Delivery<Client>
    {
        public PickPointDelivery(Reference_Information.Address PickPointAddress)
        {
            Address = PickPointAddress;
        }
    }
}
