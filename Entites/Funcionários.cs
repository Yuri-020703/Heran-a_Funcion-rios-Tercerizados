using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herança_Polimorfismo_Exercício_.Entites
{
    internal class Funcionários
    {
        public string Name { get; set; }
        public int Hours { get; set; }
        public double ValuePerHour { get; set; }

        public Funcionários()
        {

        }

        public Funcionários(string name, int hours, double valuePerHour)
        {
            Name = name;
            Hours = hours;
            ValuePerHour = valuePerHour;
        }

        public virtual double Payment(Funcionários funcionario)
        {
            return Hours * ValuePerHour;
        }
    }
}
