using System;

namespace Calculadora
{
    internal class Program
    {
        static void Main(string[] args)
        {
            


            Console.WriteLine("Bem vinda a nossa calculadora Malluzinha.");
            Console.WriteLine("Digite 1 para ligar a calculadora ou outra tecla para desligar.");
            int onoff = int.Parse(Console.ReadLine());

            if (onoff == 1)
            {
                do
                {
                    Console.WriteLine("Digite o primeiro numero: ");
                    int num1 = int.Parse(Console.ReadLine());

                    Console.WriteLine("Digite a operação desejada: ");
                    string operacao = Console.ReadLine();

                    Console.WriteLine("Digite o segundo numero: ");
                    int num2 = int.Parse(Console.ReadLine());

                    switch (operacao)
                    {
                        case "+":
                            Console.WriteLine("Resultado: " + Soma(num1, num2));
                            break;
                        case "-":
                            Console.WriteLine("Resultado: " + Subt(num1, num2));
                            break;
                        case "*":
                            Console.WriteLine("Resultado: " + Multiplica(num1, num2));
                            break;
                        case "/":
                            Console.WriteLine("Resultado: " + Divisao(num1, num2));
                            break;
                        default:
                            Console.WriteLine("Operação Invalida.");
                            break;

                    }

                    Console.WriteLine("Digite 1 se deseja continuar ou qualquer outro numero se desjar desligar. ");
                    onoff = int.Parse(Console.ReadLine());

                }

                while (onoff == 1);
                Console.WriteLine("Calculadora desligada.");

            }
            else 
            {
                Console.WriteLine("Calculadora desligada.");
            }

        }

        public static string Soma(int num1, int num2)
        {
            return (num1 + num2).ToString();
        }

        public static string Subt(int num1, int num2)
        {
            return (num1 - num2).ToString();
        }
        public static string Multiplica(int num1, int num2)
        {
            return (num1 * num2).ToString();
        }

        public static string Divisao(int num1, int num2)
        {
            if (DividendoZeroOuMenor(num2))
            {
                return "Não foi possivel dividir, numero é zero ou menor.";
            }

            return (num1 / num2).ToString();

            bool DividendoZeroOuMenor(int num2)
            {
                if (num2 <= 0)
                {
                    return true;
                }
                return false;
            }
        }
    }
}
