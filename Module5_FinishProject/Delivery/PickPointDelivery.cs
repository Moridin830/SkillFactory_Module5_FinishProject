using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module5_FinishProject
{
    internal class PickPointDelivery : Delivery<Client>
    {
        public PickPointDelivery(Client Customer)
        {
            Address = Customer.DeliveryAddress;
        }
    }
}
