// using _05_ByteBank;
using System;

namespace ByteBank
{
    public class ContaCorrente
    {
        public Cliente Titular { get; set; }

        public static int TotalDeContasCriadas { get; private set; }

        public int ContadorSaquesNaoPermitidos { get; set; }
        public int ContadorTransferenciasNaoPermitidas { get; set; }

        private int _agencia;
        // poderia ser public readonly int _agencia;
        public int Agencia { get; }
        public int Numero { get; }

        private double _saldo = 100;

        public double Saldo
        {
            get
            {
                return _saldo;
            }
            set
            {
                if (value < 0)
                {
                    return;
                }

                _saldo = value;
            }
        }


        public ContaCorrente(int agencia, int numero)
        {
            if (agencia <= 0)
                throw new ArgumentException("O campo agência não pode ser menor ou igual a 0", nameof(agencia));

            if (numero <= 0)
                throw new ArgumentException("O campo número não pode ser menor ou igual a 0", nameof(numero));

            Agencia = agencia;
            Numero = numero;

            TotalDeContasCriadas++;
        }


        public void Sacar(double valor)
        {
            if (valor < 0)
                throw new ArgumentException("O argumento " + nameof(valor) + " é inválido");

            if (_saldo < valor)
            {
                ContadorSaquesNaoPermitidos++;
                throw new SaldoInsuficienteException(valor, Saldo);
            }

            _saldo -= valor;
        }

        public void Depositar(double valor)
        {
            _saldo += valor;
        }


        public void Transferir(double valor, ContaCorrente contaDestino)
        {
            try
            {
                Sacar(valor);
            } catch (SaldoInsuficienteException e)
            {
                ContadorTransferenciasNaoPermitidas++;
                throw new OperacaoFinanceiraException("Operação não realizada.", e);
            }
            contaDestino.Depositar(valor);
        }
    }
}
