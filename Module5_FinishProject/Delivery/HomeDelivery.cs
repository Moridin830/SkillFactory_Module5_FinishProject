using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module5_FinishProject
{
    internal class HomeDelivery<TCustomer> : Delivery<TCustomer>
    {
        public HomeDelivery(Client Customer)
        {
            Address = Customer.DeliveryAddress;
        }

        public HomeDelivery(Entity Customer)
        {
            Address = Customer.DeliveryAddress;
        }
    }
}
