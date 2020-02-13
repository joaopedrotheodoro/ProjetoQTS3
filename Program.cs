using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aaaaaaaaaaaaaaaaa
{
    class Program
    {
        static void Main(string[] args)
        {
            VendasTrufa c = new VendasTrufa();
            double valor = 0;
            int quantidade = 0;
            double valorfinal = 0;

            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();

            Console.WriteLine("Informe o valor unitário da trufa ");
            valor = double.Parse(Console.ReadLine());


            Console.WriteLine("Informe a quantidade de trufas que deseja comprar ");
            quantidade = int.Parse(Console.ReadLine());

            c.preco = valor;
            c.qtd = quantidade;

            valorfinal = c.valortotal();
           
            Console.ReadKey();

        }

        public class VendasTrufa
        {
            //valor unitário, qtd
            //calcular: valor total,qtd complada, a cada 10 somar +1

            public double preco;
            public int qtd;

            public double valortotal()
            {
                double valortotal = 0;
                valortotal = qtd * preco;

                if(qtd >= 10)
                {
                    qtd = qtd + 1;
                    Console.WriteLine(" Serão " + qtd + " trufas, pois você ganhou uma, o valor será de " + valortotal);

                }
                else
                {
                    Console.WriteLine(" Serão " + qtd + " trufas, o valor será de " + valortotal);
                }
                return valortotal;
            }



        }
    }
}
