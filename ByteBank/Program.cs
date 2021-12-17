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


            Console.WriteLine("Fim da execução do programa. Tecle enter para continuar ...");
            Console.ReadLine();
        }

        private static void TestaInnerException()
        {
            try
            {
                ContaCorrente contaCorrente = new ContaCorrente(4567, 439603);
                ContaCorrente contaCorrente1 = new ContaCorrente(3567, 346723);

                contaCorrente1.Transferir(10000, contaCorrente);
            }
            catch (OperacaoFinanceiraException e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine(e.StackTrace);

                Console.WriteLine("Informações da INNER EXCEPTION (exceção interna):");

                Console.WriteLine(e.InnerException.Message);
                Console.WriteLine(e.InnerException.StackTrace);
            }
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
