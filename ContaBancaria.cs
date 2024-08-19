using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace PrimeiroProjeto
{
    internal class ContaBancaria
    {
        public int Numero { get; private set; }
        public string Titular { get; set; }
        public double Saldo { get; private set; }

        public ContaBancaria(int numero, string nome)
        {
            Numero = numero;
            Titular = nome;
        }

        public ContaBancaria(int numero, string nome, double depositoinicial) : this(numero, nome)
        {
            Deposito(depositoinicial);
        }

        public void Deposito(double quantia)
        {
            Saldo += quantia;
        }
         public void Saque(double quantia)
        {
            Saldo -= quantia;
            Saldo -= 5.00;
        }


        public override string ToString()
        {
            return "Conta "
                + Numero
                + ", Titular:"
                + Titular
                + ", Saldo: $"
                + Saldo.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
