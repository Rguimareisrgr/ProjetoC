using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Reflection.Metadata;
using System.ComponentModel;

namespace PrimeiroProjeto
{
    internal class Produto
    {
        private string _nome;
        //private double _preco;
        //private int _quantidade;

        //Auto Properties Inicio  - prop
        public double Preco { get; private set; }
        public int Quantidade { get; private set; }
        //Auto Properties Fim

        public Produto()
        {

        }

        public Produto(string nome, double preco, int quantidade)
        {
            _nome  = nome;
            Preco = preco;
            Quantidade = quantidade;
        }
        //Properties Inicio
        public string Nome
        {
            get { return _nome; }
            set {
                if (value != null && value.Length > 1)
                {
                    _nome = value;
                }

            }

        }        
        
        /*public double Preco
        {
            get
            {
                return _preco;
            }

        }
        public int Quanidade
        {
            get
            {
                return _quantidade;
            }
        }*/
        //Properties Fim

        /*
         public string GetNome()
        {
            return _nome;
        }

        public void SetNome(string nome)
        {
            if(nome != null && nome.Length > 1)
            {
                _nome = nome;
            }
        }  */

        /* public Produto(string nome, double preco)
        {
            Nome = nome;
            Preco = preco;
            Quantidade = 5;
        }*/



        public double ValorTotalEstoque()
        {
            return Preco * Quantidade;
        }

        public void AdicionarProdutos(int quantidade)
        {
            Quantidade = Quantidade + quantidade;
        }

        public void RemoverProdutos(int quantidade)
        {
            Quantidade = Quantidade - quantidade;
        }

        public override string ToString()
        {
            return _nome 
                + ", $ " 
                + Preco.ToString("F2", CultureInfo.InvariantCulture)
                + ", "             
                + Quantidade
                + " unidades, Total: $"
                + ValorTotalEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
