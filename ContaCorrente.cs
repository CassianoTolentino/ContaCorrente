using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Exercicio7
{
    class ContaCorrente : Componentes
    {
        private string idConta;
        private string nomeCorrentista;
        private double saldo;

        public ContaCorrente(string _nomeCorrentista)
        {
            SetIdConta(GeradorIdConta());
            SetNomeCorrentista(_nomeCorrentista);
            SetSaldo(0);
        }

        public void ImprimeConta()
        {
            Console.WriteLine("\nID da Conta: " + GetIdConta());
            Console.WriteLine("Nome Correntista: " + GetNomeCorrentista());
            Console.WriteLine("Saldo: " + GetSaldo().ToString("C", CultureInfo.CurrentCulture));
        }

        public void RealizarDeposito(double _valor)
        {
            SetSaldo(GetSaldo() + _valor);
        }

        public void RealizarSaque(double _valor)
        {
            if(GetSaldo() < _valor)
            {
                Console.WriteLine("Invalido para o Correntista: " + GetNomeCorrentista());
                Console.WriteLine("Valor do saque maior que o disponivel na conta");
            } else
            {
                SetSaldo(GetSaldo() - _valor);
            }
        }

        private void SetIdConta(string _idConta)
        {
            this.idConta = _idConta;
        }

        private void SetNomeCorrentista(string _nomeCorrentista)
        {
            this.nomeCorrentista = _nomeCorrentista;
        }

        private void SetSaldo(double _saldo)
        {
            this.saldo = _saldo;
        }

        public string GetIdConta()
        {
            return this.idConta;
        }

        public string GetNomeCorrentista()
        {
            return this.nomeCorrentista;
        }

        public double GetSaldo()
        {
            return this.saldo;
        }


    }
}
