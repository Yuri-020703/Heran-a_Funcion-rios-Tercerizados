using Herança_Polimorfismo_Exercício_.Entites;
using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace Herança_Polimorfismo_Exercício_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Quantos funcionários serão cadastrados? ");
            int n = int.Parse(Console.ReadLine());

            List<Funcionários> lista = new List<Funcionários>();

            for(int i = 0; i< n; i++)
            {
                Console.WriteLine($"Dados do funcionário {i + 1}: ");
                Console.Write("Este funcionário é tercerizado? (s/n): ");
                char ch = char.Parse(Console.ReadLine());
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Quantidade de horas trabalhadas: ");
                int horas = int.Parse(Console.ReadLine());
                Console.Write("$ Valor por hora: ");
                double valorPorHora = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                if(ch == 's')
                {
                    Console.Write("$ Despesa adicional: ");
                    double despesaAdicional = double.Parse(Console.ReadLine());
                    lista.Add(new FuncionárioTercerizado(nome, horas, valorPorHora, despesaAdicional));
                } else
                {
                    lista.Add(new Funcionários(nome, horas, valorPorHora));
                }
                Console.WriteLine();
            }

            Console.WriteLine();
            Console.WriteLine("PAGAMENTOS: ");
            foreach(Funcionários obj in lista)
            {
                Console.WriteLine(obj.Name + " - $ " + obj.Payment(obj).ToString("F2", CultureInfo.InvariantCulture));
            }

        }
    }
}
