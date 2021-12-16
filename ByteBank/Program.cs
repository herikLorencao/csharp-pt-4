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
                ContaCorrente contaCorrente = new ContaCorrente(0, 0);
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
                // seria o mesmo que throw e;
                throw;
            }
        }

        private static int Dividir(int numero, int divisor)
        {
            return numero / divisor;
        }
    }
}
