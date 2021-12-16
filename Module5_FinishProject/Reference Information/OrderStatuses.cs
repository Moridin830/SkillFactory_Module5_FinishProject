using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module5_FinishProject
{
    /// <summary>
    /// Статусы заказа
    /// </summary>
    public enum OrderStatuses : byte
    {
        Created,
        Confirmed,
        Paid,
        InTheProcessOfDelivery,
        Delivered,
        Canceled
    }
}
