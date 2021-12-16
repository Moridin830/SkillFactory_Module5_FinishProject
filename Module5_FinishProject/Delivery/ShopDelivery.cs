using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module5_FinishProject
{
    /// <summary>
    /// Класс для описания доставки до магазина. Доступен для физического лица
    /// </summary>
    internal class ShopDelivery : Delivery<Client> 
    {
       public ShopDelivery(Reference_Information.Address ShopAddress)
        {
            Address = ShopAddress;
        }
    }
}
