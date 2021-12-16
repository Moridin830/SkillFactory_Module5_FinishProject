using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module5_FinishProject
{
    //Абстрактный класс для описания позиции заказе (товар либо услуга). 
    abstract internal class OrderItem
    {
        public int Article;
        public string Name;
        public string Description;
        public double Cost;
    }
}
