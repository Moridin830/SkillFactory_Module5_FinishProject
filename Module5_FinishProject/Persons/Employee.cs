using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module5_FinishProject
{
    /// <summary>
    /// Класс для описания сотрудника магазина
    /// </summary>
    internal class Employee : Person
    {
        public Reference_Information.Positions Position;

        public Employee(Reference_Information.Positions Position)
        {
            this.Position = Position;
        }
    }
}
