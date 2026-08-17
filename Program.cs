using OlaMundo.Objetos;
using System.ComponentModel;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace OlaMundo
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Declaracoes de variaveis
            /*{
                bool estado = true;
                char genero = 'f';
                char genero2 = '\u0046';
                byte n1 = 23;
                int n2 = 1000;
                int n3 = 2147483647;
                long n4 = 21474836488;
                float n5 = 1.1f;
                double n6 = 57.1352132;
                string n7 = "Maria";
                object n8 = "objeto caua";
                int n9 = int.MinValue;
                int n10 = int.MaxValue;
                decimal n11 = decimal.MaxValue;


                //concatenacao
                Console.WriteLine(n7 + " tem " + n1 + " anos e pesa " + n6.ToString("F2") + " kilos");
                //placeholder
                Console.WriteLine($"{0} tem {1} anos e pesa {2:F2} kilos", n7, n1, n6);
                //Interpolacao
                Console.WriteLine($"{n7} tem {n1} anos e pesa {n6:F2} kilos");

                //Exercicio Aula 19
                string produto1 = "computador", produto2 = "Mesa de escritorio";
                byte idade = 30;
                int codigo = 5290;
                char gen = 'M';
                double preco1 = 2100.0, preco2 = 650.60, medida = 53.234567;
                Console.WriteLinaor decimal invariante culture: {medida.ToString("F3", CultureInfo.InvariantCulture)}");
            }e($"\n\nProdutos : \n{produto1},cujo preço é {preco1}\n{produto2},cujo preço é{preco2}");
                Console.WriteLine($"\nRegistro: {idade} anos de idade, código: {codigo}, e gênero: {gen}");
                Console.WriteLine($"Medida com oito casas decimais{medida}\nArredondado(três casas decimais) : {medida:F3}");
                Console.WriteLine($"Separ

            //Operadores de atribuição
            {
                int a = 2;
                Console.WriteLine(a);
                a += 2; // a = a + 2
                Console.WriteLine(a);
                a -= 2; // a = a - 2
                Console.WriteLine(a);
                a *= 2; // a = a * 2
                Console.WriteLine(a);
                a /= 2; // a = a / 2
                Console.WriteLine(a);
                a %= 2; // a = a % 2
                Console.WriteLine(a);

                int b = 5;
                int bb = 10;
                bb = ++b; // Pré-Incremento b+1 vai para bb
                Console.WriteLine(b);
                bb = --b; // Pré-Incremento b-1 vai para bb
                Console.WriteLine(b);
                bb = b++; // Pós-Incremento bb recebe b depois b recebe b+1
                Console.WriteLine(bb);
                bb = b--; // Pós-Incremento bb recebe b depois b recebe b-1
                Console.WriteLine(bb);
            }
            //Concatenação cumulativa de string
            {
                string c = "ABC";
                Console.WriteLine(c);
                c += "DEF";
                Console.WriteLine(c);
            }
            //Casting - Conversão
            {
                // De float pra double (menor para maior) funciona implicitamente
                float d = 3.4f;
                double d2 = d;
                Console.WriteLine(d2);
                // De double para float (maior para menor) tem que deixar explicito, por que vai ter perda de dados
                double d3 = 3.4f;
                float d4 = (float)d3;
                Console.WriteLine(d4);
                // De doble para int(maior para menor)
                double d5 = 5.144235453453454534543512312315545363346456456;
                int d6 = (int)d5;
                Console.WriteLine(d6);
                // De int para double
                int d7 = 5;
                double d8 = d7;
                Console.WriteLine(d8);
                //Operação com tipos diferentes
                int d9 = 5, d10 = 2;
                double d11 = d9 / d10; //Resultado = 2, esta errado, operou com int saiu int
                Console.WriteLine(d11);
                double d12 = (double)d9 / d10; //Resultado = 2.5, Correto, fez a conversão na frente do int
                Console.WriteLine(d12);
            }



            //Entrada e saida normal
            {
                string? frase = Console.ReadLine();
                string? x = Console.ReadLine();
                string? y = Console.ReadLine();
                string? z = Console.ReadLine();
                string? a = Console.ReadLine();
                string? b = Console.ReadLine();
                string? c = Console.ReadLine();
                Console.WriteLine("Conteudo digitado: ");
                Console.WriteLine("Frase: " + frase + "\nX: " + x + "\nY: " + y);
                Console.WriteLine("z: " + z + "\nA: " + a + "\nB: " + b + "\nC: " + b);
            }

            //Recorte de String
            {
                string?[] vet = Console.ReadLine().Split(' ');
                string? p1 = vet[0];
                string? p2 = vet[1];
                string? p3 = vet[2];
                Console.WriteLine($"\n{p1}\n{p2}\n{p3}");
            }

            //Formataçãoo de entrada
            {
                int fInt = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                char fChar = char.Parse(Console.ReadLine());
                double fDouble = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.WriteLine($"{fInt}\n{fChar}\n{fDouble}");

                string[] vetor = Console.ReadLine().Split(' ');
                Console.WriteLine($"{vetor[0]},{char.Parse(vetor[1])},{int.Parse(vetor[2])},{double.Parse(vetor[3])}");
            }
            Console.WriteLine("Digite 3 numeros separados por espacço ' ':\n");
            string[] n = Console.ReadLine().Split(" ");
            int n1 = int.Parse(n[0]);
            int n2 = int.Parse(n[1]);
            int n3 = int.Parse(n[2]);

            Maior(n1,n2,n3);
            }

            //for em C#
            Console.WriteLine("Digie 2 numeros separados por Enter");
            int i = Convert.ToInt32(Console.ReadLine());
            int io = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"contando de {i} ate {io}");
            for (; i <= io; i++)
            {
                Console.WriteLine(i);
            }

            //Resolvendo um problema SEM orientacao a objetos
            Console.WriteLine("Entre com as medidas do triangulo X");
            double xA = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            Console.WriteLine("Valor digitado " + xA);
            double xB = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Valor digitado " + xB);
            double xC = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Valor digitado " + xC);

            Console.WriteLine("Entre com as medidas do triangulo Y");
            double yA = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Valor digitado " + yA);
            double yB = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Valor digitado " + yB);
            double yC = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Valor digitado " + yC);

            double xP = (xA + xB + xC) / 2.0;
            double areax = Math.Sqrt(xP*(xP - xA)*(xP - xB)*(xP - xC));


            double yP = (yA + yB + yC) / 2.0;
            double areay = Math.Sqrt(yP * (yP - yA) * (yP - yB) * (yP - yC));

            Console.WriteLine($"Area de X ={areax.ToString("F4", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"Area de Y ={areay.ToString("F4", CultureInfo.InvariantCulture)}");

            if (areax > areay)
            {
                Console.WriteLine("Maior Area : X");
            }
            else { 
                Console.WriteLine("Maior Area : Y");
            }*/

            //Resolvendo um problema COM orientacao a objetos
            Console.WriteLine("Entre com as medidas do triangulo X");

            var x = new Triangulo()
            {
                Lado1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture),
                Lado2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture),
                Lado3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture)
            };

            x.mostrarLados(); 

            Console.WriteLine("\n Entre com as medidas do triangulo Y");

            var y = new Triangulo()
            {
                Lado1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture),
                Lado2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture),
                Lado3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture)
            };

            y.mostrarLados();

            double py = (y.Lado1 + y.Lado2 + y.Lado3) / 2.0;
            double areay = Math.Sqrt(py * (py - y.Lado1) * (py - y.Lado2) * (py - y.Lado3));

            double px = (x.Lado1 + x.Lado2 + x.Lado3) / 2.0;
            double areax = Math.Sqrt(px * (px - x.Lado1) * (px - x.Lado2) * (px - x.Lado3));


            Console.WriteLine($"Area de X ={areax.ToString("F4", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"Area de Y ={areay.ToString("F4", CultureInfo.InvariantCulture)}");




            /*
            //Usando funções (vão ser chamadas na main)

            private static int Maior(int n1,int n2,int n3) {
                if (n1 > n2 && n1 > n3) {
                    Console.WriteLine($"\nO maior numero é o : {n1}");
                    return n1;
                }
                else if (n2 > n1 && n2 > n3) {
                    Console.WriteLine($"\nO maior numero é o : {n2}");
                    return n2;
                }
                else if (n3 > n1 && n3 > n2)
                {
                    Console.WriteLine($"\nO maior numero é o : {n3}");
                    return n3;
                }
                else {
                    Console.WriteLine("Valor invalido");
                    return 0;
                }*/
        }

    }
}