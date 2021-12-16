using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module5_FinishProject
{
    internal class CustomerOrder : Order<Client>
    {

        public new OrderItem[] ItemList
        {
            get
            {
                return this.ItemList;
            }
            private set
            {
                if (Status != OrderStatuses.Created)
                {
                    Console.WriteLine("The order has already been generated. It is not possible to add an item.");
                }
            }
        }

        public CustomerOrder(string Description, OrderItem Item)
        {
            Id = Order<Client>.CurrentMaxId;
            this.Description = Description;
            Status = OrderStatuses.Created;
            ItemList = new OrderItem[1];
            ItemList[0] = Item;
        }

        public CustomerOrder(string Description, OrderItem[] Items)
        {
            Id = Order<Client>.CurrentMaxId;
            this.Description = Description;
            Status = OrderStatuses.Created;
            ItemList = Items;
        }

        public CustomerOrder(string Description, OrderItem[] Items, Client Customer)
        {
            Id = Order<Client>.CurrentMaxId;
            this.Description = Description;
            Status = OrderStatuses.Created;
            ItemList = Items;
            this.Customer = Customer;           
        }

        public void AddItem(OrderItem Item)
        {
            if (Status == OrderStatuses.Created)
            {
                ItemList.Append(Item);
            }
            else
            {
                Console.WriteLine("The order has already been generated. It is not possible to add an item.");
            }
        }
    }
}
