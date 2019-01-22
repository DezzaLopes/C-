using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraApp
{
    class Program
    {
        static void Main(string[] args)
        {
            double numeroUM;
            double numeroDois;
            double resultado;
            string opcao;

            Console.WriteLine("Escolha uma opcao: \n 1- Somar \n 2- Subtrair \n 3- Multiplicar \n 4- Dividir \n enjoy");

            opcao = Console.ReadLine();

            
            Console.Write("Digite o primeiro numero: ");
            numeroUM = double.Parse(Console.ReadLine());

            Console.Write("Digite o segundo numero: ");
            numeroDois = double.Parse(Console.ReadLine());

            if (opcao.Equals("1"))  
            {
                resultado = numeroUM + numeroDois;
                Console.WriteLine(resultado);
            }
            if (opcao.Equals("2"))
            {
                resultado = numeroUM - numeroDois;
                Console.WriteLine(resultado);
            }
            if (opcao.Equals("3"))
            {
                resultado = numeroUM * numeroDois;
                Console.WriteLine(resultado);
            }
            if (opcao.Equals("4"))
            {
                if(numeroDois != 0)
                {
                    resultado = numeroUM / numeroDois;
                    Console.WriteLine(resultado);
                }
                else
                {
                        Console.WriteLine("Não pode ser dividido por 0");
                }
            }
           

            Console.ReadKey(true); //comando para esperar enter p poder fechar, tipo system pause 

            //crie um menu que receba uma opção
            /* 1- soma, 2- subtração, 3- multiplicação 4- divisão
             * 
             * Como ler um número e transformar de string para double
             * 
             * comando para imprimir:
             * 
             * Console.WhiteLine("digite o numero:");
             * 
             * comando para receber:
             * 
             * numeroUM = double.Parse(Console.ReadLine());
             * 
             * receber 2 números: numeroUM, numeroDois
             * 
             * Console.writeLn(resultado);
             * */

            
        }
    }
}

