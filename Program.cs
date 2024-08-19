// See https://aka.ms/new-console-template for more information
using System;
using System.Globalization;
using System.Net.Http.Headers;
using System.Numerics;
using System.Threading.Channels;
using System.Transactions;
using System.Xml;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq.Expressions;
using System.Reflection.Metadata.Ecma335;

namespace PrimeiroProjeto
{
    class Program
    {
        static void Main(string[] args)
        {
            int indice = 13, soma = 0, k = 0;

            while (k < indice)
            {
                k = k + 1;
                soma = soma + k;
                
            }
            Console.WriteLine(soma);

            /* Formatação de Data e Hora
             
            DateTime d1 = DateTime.Now;
            DateTime d2 = new DateTime(2024, 8, 16);
            DateTime d3 = new DateTime(2024, 8, 16, 18, 00,00);
            DateTime d4 = DateTime.Today;
            DateTime d5 = DateTime.UtcNow;
            
            DateTime d6 = DateTime.Parse("2000-08-15");
            DateTime d7 = DateTime.Parse("2000-08-15 15:45:10");
            DateTime d8 = DateTime.Parse("16/08/2024");
           
            DateTime d9 = DateTime.ParseExact("2024-08-16", "yyyy-MM-dd", CultureInfo.InvariantCulture);
            DateTime d10 = DateTime.ParseExact("01/02/1963 16:00:00", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture);

            Console.WriteLine(d1);
            Console.WriteLine(d2);
            Console.WriteLine(d3);
            Console.WriteLine(d4);
            Console.WriteLine(d5);
            Console.WriteLine("DateTme.Parse");
            Console.WriteLine(d6);
            Console.WriteLine(d7);
            Console.WriteLine(d8);
            Console.WriteLine("DateTime.ParseExtrac");
            Console.WriteLine(d9);
            Console.WriteLine(d10);

            Tratar STRINGS
            
            string original = "abcd FGHR abc TYY    ";

            string s1 = original.ToUpper();
            string s2 = original.ToLower();
            string s3 = original.Trim();
            string s4 = original.Substring(3);
            string s5 = original.Substring(3, 5);
            string s6 = original.Replace('a', 'x');
            string s7 = original.Replace("abc", "xy");
            bool b1 = string.IsNullOrEmpty(original);
            bool b2 = string.IsNullOrWhiteSpace(original);


            int n1 = original.IndexOf("bc");
            int n2 = original.LastIndexOf("bc");


            Console.WriteLine(original);
            Console.WriteLine(s7);
            Console.WriteLine(b2);
            Console.WriteLine(n2);



            expressão condicional ternária
             
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double desconto = (preco < 20.0) ? preco * 0.1 : preco * 0.05;

            Console.WriteLine(desconto);

            Aula de SWITCH CASE
            int x = int.Parse(Console.ReadLine());
            string day;

            switch (x) { 
                case 1:
                    day = "Sunday";
                    break;
                case 2:
                    day = "Monday";
                    break;
                case 3:
                    day = "Tuesday";
                    break;
                case 4:
                    day = "Wendnesday";
                    break;
                case 5:
                    day = "Thrusday";
                    break;
                case 6:
                    day = "Fruday";
                    break;
                case 7:
                    day = "Saturday";
                    break;
                default:
                    day = "Valor invalido";
                    break;
            }
            Console.WriteLine("Day " + day);

            Aula de MATRIZ parte 2
            int n = int.Parse(Console.ReadLine());

            int[,] mat = new int[n, n];

            for (int i = 0; i < n; i++)
            {
                string[] valor = Console.ReadLine().Split(' ');

                for (int j = 0; j < n; j++)
                {
                    mat[i, j] = int.Parse(valor[j]);
                }
            }

            Console.WriteLine("Main diagona:");
            for (int i = 0; i < n; i++)
            {
                Console.Write(mat[i,i] + " ");
            }

            Console.WriteLine();

            int count = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if(mat[i, j] < 0)
                    {
                        count++; 

                    }
                }
            }
            Console.WriteLine("Negativ numbers:" + count);



            Aula de MATRIZ parte 1
            double[,] mat = new double[2, 3];

            Console.WriteLine(mat.Length);

            Console.WriteLine(mat.Rank);

            Console.WriteLine(mat.GetLength(0));

            Console.WriteLine(mat.GetLength(1));

            Aula de LISTA
            List<string> list = new List<string>();
            list.Add("Maria");
            list.Add("Mario");
            list.Add("Bob");
            list.Insert(2, "Ricardo");

            foreach (string s in list)
            {
                Console.WriteLine(s);
            }
            Console.WriteLine("Total de Lista: " + list.Count);

            string s1 = list.Find(x => x[0] == 'M');
            Console.WriteLine("Primeiro : " + s1);

            string s2 = list.FindLast(x => x[0] == 'M');
            Console.WriteLine("Ultimo : " + s2);

            int pos1 = list.FindIndex(x => x[0] == 'M');
            Console.WriteLine("Posição : " + pos1);

            int pos2 = list.FindLastIndex(x => x[0] == 'M');
            Console.WriteLine("Posição : " + pos2);

            List<string> list2 = list.FindAll(x => x.Length == 3);
            foreach (string obj in list2)
            {
                Console.WriteLine(obj);
            }

            Console.WriteLine("---------------------------");
            list.Remove("Bob");
            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }

            Console.WriteLine("----------------------------");
            list.RemoveAll(x => x[0] == 'R');
            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }

            Console.WriteLine("-----------xxx----------------");
            list.RemoveAt(0);
            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }

            Console.WriteLine("-----------xxx----------------");
            list.RemoveRange(0, 2);
            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }


            Aula de FOREACH

           string[] vect = new string[] { "Maria", "Alex", "Bob" };

           foreach (string obj in vect)
           {
               Console.WriteLine(obj);
           }


            Aula de OUT

           int a = 10;
           int total;
           Calcula.Triple(a, out total);
           Console.WriteLine(total);

            Aula de REF

            int a = 10;
           Calcula.Triple(ref a);
           Console.WriteLine(a);


            Exercicio de Vetor
             Console.Write("Informe a quantidade de Hospedi: ");
           int n = int.Parse(Console.ReadLine());

           Hospedi[] vect = new Hospedi[10];

           for (int i = 0; i < n; i++)
           {
               Console.Write("Informe o nome do Hospedi: ");
               string nome = Console.ReadLine();
               Console.Write("Informe o E-mail do hospedi: ");
               string email = Console.ReadLine();
               Console.Write("Indorme o numero do quarto: ");
               int quarto = int.Parse( Console.ReadLine());

               vect[quarto] = new Hospedi { Nome = nome, Email = email };

           }

           for (int i =0; i < vect.Length; i++)
           {
               if (vect[i] != null)
               {
                   Console.WriteLine("Quarto - " + i + ": " + vect[i].Nome + ", " + vect[i].Email );
               }
           }



            Aula Vetor Parte 2 Tipo Classe
           int n = int.Parse(Console.ReadLine());

           Produto1[] vect = new Produto1[n];

           for(int i = 0; i < n; i++)
           {
               string nome = Console.ReadLine();
               double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

               vect[i] = new Produto1 { Nome = nome, Preco = preco };
           }

           double sum = 0.00;
           for(int i = 0; i < n; i++)
           {
               sum += vect[i].Preco;
           }

           double avg = sum / n;

           Console.WriteLine("Preço medio = " + avg.ToString("F2", CultureInfo.InvariantCulture));



           Aula Vetor Parte 1 Tipo Struct

            int n = int.Parse(Console.ReadLine());

           double[] vect = new double[n];

           for(int i = 0; i < n; i++)
           {
               vect[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
           }

           double sum = 0.0;

            for(int i =0; i < n; i++)
           {
               sum += vect[i];

           }

           double avg = sum / n;

           Console.WriteLine("Altura media = " + avg.ToString("F2", CultureInfo.InvariantCulture));

           double? x = null;
           double? y = 10.00;

           double a = x ?? 5.00;
           double b = y ?? 5.00;

           Console.WriteLine(a);
           Console.WriteLine(b);

           Console.WriteLine(x.GetValueOrDefault());
           Console.WriteLine(y.GetValueOrDefault());

           Console.WriteLine(x.HasValue);
           Console.WriteLine(y.HasValue);

           if (x.HasValue)
           {
               Console.WriteLine(x.Value);
           }
           else
           {
               Console.WriteLine("X is null");
           }
           if (y.HasValue)
           {
               Console.WriteLine(y.Value);
           }
           else
           {
               Console.WriteLine("Y is null");
           }




            ContaBancaria conta;

            Console.Write("Entre como numero da Conta:");
            int numero = int.Parse(Console.ReadLine());
            Console.Write("Entre com o nume do Tirular");
            string titular = Console.ReadLine();
            Console.Write("Havera deposito inicial (s/n)?");
            char resp = char.Parse(Console.ReadLine());
            if (resp == 's' || resp == 'S'){
                Console.Write("Entre com o valor inicial: ");
                double depositoInicial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                conta = new ContaBancaria(numero, titular, depositoInicial);
            }
            else
            {
                conta = new ContaBancaria(numero, titular);
            }

            Console.WriteLine(  );
            Console.WriteLine("Dados da Conta:");
            Console.WriteLine(conta);

            Console.WriteLine();
            Console.Write("Entre com o valor de deposito: ");
            double quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.Deposito(quantia);
            Console.WriteLine("Dados da conta atualizados");
            Console.WriteLine(conta);

            Console.WriteLine();
            Console.Write("Entre com o valor do saque: ");
            quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.Saque(quantia);
            Console.WriteLine("Dados da conta atualizados");
            Console.WriteLine(conta);*/



            //string produto1 = "Computador";
            //string produto2 = "Mesa de escritório";

            //byte idade = 30;
            //int codigo = 5290;
            //char genero = 'M';

            //double preco1 = 2100.0;
            //double preco2 = 650.50;
            //double medida = 53.234567;

            //Console.WriteLine("Produto:");
            //Console.WriteLine(produto1 + ", cujo preço é $ " + preco1.ToString("F2"));
            //Console.WriteLine(produto2 + ", cujo preço é $ " + preco2.ToString("F2"));
            //Console.WriteLine();
            //Console.WriteLine("Registro: " + idade + " anos de idade, código " + codigo + " e gênero: " + genero);
            //Console.WriteLine();
            // Console.WriteLine("Medida com oito casas decimais: " + medida.ToString("F8"));
            //Console.WriteLine("Arredondando (três casas decimais): " + medida.ToString("F3") );
            //Console.WriteLine("Separador decimal invariant culture: " + medida.ToString("F3", CultureInfo.InvariantCulture));
            //Entrada
            //Console.WriteLine("Entre com o seu nome completo.");
            //string nomec = Console.ReadLine();
            //Console.WriteLine("Quantos quartos tem na sua casa?");
            //int quartos = int.Parse(Console.ReadLine());
            //Console.WriteLine("Entre com o preço de produto");
            //double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //Console.WriteLine("Entre com o nome, idade e altura(mesma linha)");
            //

            //String[] vet = Console.ReadLine().Split(' ');
            //string nome = vet[0];
            //int idade = int.Parse(vet[1]);
            //double altura = double.Parse(vet[2], CultureInfo.InvariantCulture);

            //Console.WriteLine("Voce digitou:");
            //Console.WriteLine(nomec);
            //Console.WriteLine(quartos);
            //Console.WriteLine(preco.ToString("F2", CultureInfo.InvariantCulture));
            //Console.WriteLine(nome);
            //Console.WriteLine(idade);
            //Console.WriteLine(altura.ToString("F2", CultureInfo.InvariantCulture));

            //int N = int.Parse(Console.ReadLine());
            //int soma = 0;

            //for (int i = 1; i <= N; i++)
            //{
            //    
            //    Console.Write("Valor #{0}: ", i);
            //    int valor = int.Parse(Console.ReadLine());
            //
            //    soma += valor;
            //}
            //Console.WriteLine("Soma = " + soma  ); 
            //int n1 = int.Parse(Console.ReadLine());
            //int n2 = int.Parse(Console.ReadLine());
            //int n3 = int.Parse(Console.ReadLine());
            //
            //int resultado = Maior(n1, n2, n3);
            //Console.WriteLine("Maior é = " + resultado );
            // SEM ORIENTAÇÂO AO OBJETO
            //double xA, xB, xC, yA, yB, yC;
            //Console.WriteLine("Entre com as medidas do triângolo X");
            //xA = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //xB = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //xC = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //
            //Console.WriteLine("Entre com as medidas do triângolo Y");
            //yA = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //yB = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //yC = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //
            //double p = (xA + xB + xC) / 2.0;
            //double areaX = Math.Sqrt(p * (p - xA) * (p - xB) * (p - xC));
            //
            //p = (yA + yB + yC) / 2.0;
            //double areaY = Math.Sqrt(p * (p - yA) * (p - yB) * (p - yC));

            //Console.WriteLine("Area de X = " + areaX.ToString("F4", CultureInfo.InvariantCulture));
            //Console.WriteLine("Area de Y = " + areaY.ToString("F4", CultureInfo.InvariantCulture));

            //if (areaX > areaY)
            //{
            //    Console.WriteLine("Maior area: X");
            //}
            //else
            //{
            //    Console.WriteLine("Maior area: Y");
            //}

            //COM ORIENTACAO OA OBJETO

            // Triangulo x, y;
            // x = new Triangulo();
            // y = new Triangulo();

            // Console.WriteLine("Entre com as medidas do triângolo X");
            // x.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            // x.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            // x.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            // 
            // Console.WriteLine("Entre com as medidas do triângolo Y");
            // y.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            // y.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            // y.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //double p = (x.A + x.B + x.C) / 2.0;
            // double areaX = x.Area();   //Math.Sqrt(p * (p - x.A) * (p - x.B) * (p - x.C));

            //p = (y.A + y.B + y.C) / 2.0;
            // double areaY = y.Area(); // Math.Sqrt(p * (p - y.A) * (p - y.B) * (p - y.C));

            // Console.WriteLine("Area de X = " + areaX.ToString("F4", CultureInfo.InvariantCulture));
            // Console.WriteLine("Area de Y = " + areaY.ToString("F4", CultureInfo.InvariantCulture));
            //            if (areaX > areaY)
            // {
            //     Console.WriteLine("Maior area: X");
            // }
            // else
            // {
            //     Console.WriteLine("Maior area: Y");
            // }
            //********PRODUTO***********


            /* Console.WriteLine("Entre os dados do Produto:");
             Console.Write("Nome: ");
             string nome = Console.ReadLine();
             Console.Write("Preco: ");
             double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
             //Console.Write("Quantidade no estoque: ");
             //int quantidade = int.Parse(Console.ReadLine());

            Produto p = new Produto( nome,  preco, 20);

             //Produto p2 = new Produto();
             p.Nome = "TV 4K";


             Console.WriteLine(p.Nome);
             Console.WriteLine(p.Preco);

             Console.WriteLine();
             Console.WriteLine("Dados do produto: " + p);
             Console.WriteLine();
             Console.Write("Digite o numero de produtos a ser adiocionado ao estoque: ");
             int qte = int.Parse(Console.ReadLine());

             p.AdicionarProdutos(qte);
             Console.WriteLine();
             Console.WriteLine("Dados atualizados: " + p);

             Console.WriteLine();
             Console.Write("Digite o numero de produtos a ser removido do estoque: ");
             qte = int.Parse(Console.ReadLine());

             p.RemoverProdutos(qte);
             Console.WriteLine();
             Console.WriteLine("Dados atualizados: " + p);
             //********PRODUTO***********
             //Calculadora calc = new Calculadora();

             //Console.Write("Entre o valor do raio ");
             //double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
             //
             //double circ = Calculadora.Circunferencia(raio); //Circunferencia(raio);
             //double volume = Calculadora.Volume(raio); // Volume(raio);
             //
             //Console.WriteLine("Circunfgerência: " + circ.ToString("F2", CultureInfo.InvariantCulture));
             //Console.WriteLine("Volume : " + volume.ToString("F2", CultureInfo.InvariantCulture));
             //Console.WriteLine("Valor de PI: " + Calculadora.Pi.ToString("F2", CultureInfo.InvariantCulture));

             */

        }




        static int Maior(int a, int b, int c)
        {
            int m;
            if (a > b && a > c)
            {
                m = a;
            }
            else if (b > c)
            {
                m = b;
            }
            else
            {
                m = c;
            }
            return m;


        }

        static int Soma(int a, int b)
        {
            int soma = a + b; 
            int multi = a * b;

            return soma;

        }
        
        
    }
}
