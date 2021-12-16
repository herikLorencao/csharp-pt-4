using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //Metodo();
                ContaCorrente contaCorrente = new ContaCorrente(100, 229595);
                ContaCorrente contaCorrente2 = new ContaCorrente(1000, 12345);

                contaCorrente.Transferir(100, contaCorrente2);
                //contaCorrente.Sacar(200);
            }
            catch (SaldoInsuficienteException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine("Parâmetro inválido: " + ex.ParamName);
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.ReadLine();
        }

        private static void Metodo()
        {
            TestaDivisao(0);
        }

        private static void TestaDivisao(int divisor)
        {
            try
            {
                Dividir(10, divisor);
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine(e.Message);
                // no caso o throw vazio mantem a stacktrace
                // se for feito um throw e a stacktrace iniciara a partir daqui
                throw;
            }
        }

        private static int Dividir(int numero, int divisor)
        {
            return numero / divisor;
        }
    }
}
