using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module5_FinishProject.OrderItems
{
    /// <summary>
    /// Класс для описания позиции заказа типа "Услуга"
    /// </summary>
    internal class Service : OrderItem
    {
        public int PeriodOfExecution;
    }
}
