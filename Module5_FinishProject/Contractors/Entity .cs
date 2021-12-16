using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module5_FinishProject
{
    /// <summary>
    /// Класс для описания организаций
    /// </summary>
    internal class Entity 
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Reference_Information.Address Address;

        public Reference_Information.Address DeliveryAddress;

    }
}
