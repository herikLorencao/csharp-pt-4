using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank
{
    public class SaldoInsuficienteException : Exception
    {
        public SaldoInsuficienteException()
        {

        }

        public SaldoInsuficienteException(double valorSaque, double saldo) : 
            this("Foi realizada uma tentativa de saque de R$ " + valorSaque + " para uma conta com R$ " + saldo)
        {

        }

        public SaldoInsuficienteException(string mensagem) : base(mensagem)
        {

        }
    }
}
