using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module5_FinishProject
{
    /// <summary>
    /// Абстрактный класс для описания заказа покупателя. Может быть сформирован в зависимости
    /// от типа покупателя (организация/физическое лицо)
    /// </summary>
    /// <typeparam name="TCustomer"></typeparam>
    abstract internal class Order<TCustomer>
    {

        public static int CurrentMaxId 
        { 
        
            get 
            {
                CurrentMaxId++;
                return CurrentMaxId; 
            }
            private set 
            { 
                CurrentMaxId = value; 
            }
        
        }

        public virtual int Id
        {
            get
            {
                return this.Id;
            }
            set
            {
                Id = value;
            }
        }

        public virtual string Description 
        {
            get
            {
                return this.Description;
            }
            set
            {
                this.Description = value;
            }
        }

        public OrderStatuses Status;

        public OrderItem[] ItemList
        {
            get
            {
                return this.ItemList;
            }
            private set
            {
                ItemList = value;
            }
        }

        public OrderItem this[int index]
        {
            get
            {
                return (OrderItem)this[index];
            }
            set
            {
                ItemList[index] = value;
            }
        }

        public void SendFurther()
        {
            if(Status != OrderStatuses.Canceled)
            {
                Status = Status++;
            }
        }

        public TCustomer Customer;

        public Delivery<TCustomer> Delivery;
    }

    internal static class OrderExtension
    {
        public static double TotalCost (this Order<Client> Order)
        {
            double TotalCost = 0;
            foreach(OrderItem Item in Order.ItemList)
            {
                TotalCost = +Item.Cost;
            }

            return TotalCost;
        }
    }
}
