using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank
{
    public class LeitorArquivos : IDisposable
    {
        public LeitorArquivos(string nomeArquivo)
        {
            Console.WriteLine("Abrindo arquivo " + nomeArquivo);
        }

        public void LerLinha()
        {
            Console.WriteLine("Lendo linha do arquivo ...");
        }

        public void Fechar()
        {
            Console.WriteLine("Fechando arquivo.");
        }

        public void Dispose()
        {
            Fechar();
        }
    }
}
