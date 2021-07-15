using System;
using System.Collections.Generic;
using System.Text;

namespace Imposto.Entities
{
    class Company : Individual
    {
        public int employees { get; set; }

        public Company(int employees) : base(name, anualIncome)
        {
            this.employees = employees;
        }
    }
}
