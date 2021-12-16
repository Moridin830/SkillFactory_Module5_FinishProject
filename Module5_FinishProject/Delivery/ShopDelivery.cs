using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module5_FinishProject
{
    internal class ShopDelivery : Delivery<Client> 
    {
       public ShopDelivery(Client Customer)
        {
            Address = Customer.DeliveryAddress;
        }
    }
}
