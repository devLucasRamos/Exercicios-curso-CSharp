using System;
using System.Collections.Generic;
using System.Text;

namespace Imposto.Entities
{
    public class Individual
    {
        public string Name { get; set; }
        public double AnualIncome  { get; set; }
        public double HealthExpenditures { get; set; }

        public Individual(string name, double anualIncome, double healthExpenditures)
        {
            Name = name;
            AnualIncome = anualIncome;
            HealthExpenditures = healthExpenditures;
        }
    }
}
