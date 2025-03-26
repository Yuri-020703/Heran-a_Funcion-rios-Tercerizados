using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herança_Polimorfismo_Exercício_.Entites
{
    internal class FuncionárioTercerizado : Funcionários
    {
        public double DespesaAdicional { get; set; }

        public FuncionárioTercerizado()
        {

        }

        public FuncionárioTercerizado(string name, int hours, double valuePerHour, double despesa) : base(name, hours, valuePerHour)
        {
            DespesaAdicional = despesa;
        }

        public override double Payment(Funcionários funcionario)
        {
            return base.Payment(funcionario) + 1.1 * DespesaAdicional;
        }
    }
    }
