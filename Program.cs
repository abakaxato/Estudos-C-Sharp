using OlaMundo.Classes;
using static System.Net.Mime.MediaTypeNames;

namespace OlaMundo
{
    internal class Program
    {
        static void Main(string[] args)
        {

            
            //instanciando uma lista
            List<int> listaint = new List<int>();

            //instanciando uma lista já inserindo os valores
            List<string> listaStrings = new List<string> { "joao", "maria", "pedro", "mabcd", "abc","ana"};
            
            //Usando .add para adicionar valores ao final da lista
            listaStrings.Add("Texto adicionado usando add");

            //Usando o insert para adicionar valores na localização especificada na lista
            listaStrings.Insert(1, "texto adicionado usando o Insert");

            foreach (string textos in listaStrings)
            {
                Console.WriteLine(textos);
            }

            //verificando o tamanho da lista 
            Console.WriteLine("tamanho da lista " + listaStrings.Count);

            //procurando valores na lista
            string valorEncontrado = listaStrings.Find(x => x[0] == 'T');
            Console.WriteLine("valor encontrado no find : " + valorEncontrado);
            Console.WriteLine("----------------------------------------------------------");
            string valorEncontradoFinal = listaStrings.FindLast(x => x[0] == 'a');
            Console.WriteLine("valor encontrado no findLast : " + valorEncontradoFinal);
            Console.WriteLine("----------------------------------------------------------");
            //fazendo uma busca no indice que atende os requisitos
            int valorNaPosição = listaStrings.FindIndex(x => x[0] == 'm'); //usando lambda
            Console.WriteLine(valorNaPosição);
            Console.WriteLine("----------------------------------------------------------");
            int valorNaUltimaPosição = listaStrings.FindLastIndex(Predicate); // usando um predicato
            Console.WriteLine(valorNaUltimaPosição);
            Console.WriteLine("----------------------------------------------------------");

            //fazendo um filtro na lista
            List<string> listaFiltrada;
            listaFiltrada = listaStrings.FindAll(x => x.Length == 3);
            foreach (string elemento in listaFiltrada)
            {
                Console.WriteLine(elemento);
            }
            Console.WriteLine("----------------------------------------------------------");

            //metodo usado no find quando não é utilizado o lambda
            static bool Predicate(string s)
            {
                return s[0] == 'm';
            }
        }
    }
}