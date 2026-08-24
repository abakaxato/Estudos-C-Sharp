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
            Console.WriteLine("----------------------------------------------------------");
            //verificando o tamanho da lista 
            Console.WriteLine("tamanho da lista " + listaStrings.Count);
            Console.WriteLine("----------------------------------------------------------");
            //procurando valores na lista
            string valorEncontrado = listaStrings.Find(x => x[0] == 'T');
            Console.WriteLine("valor encontrado no find : " + valorEncontrado);
            Console.WriteLine("----------------------------------------------------------");
            string valorEncontradoFinal = listaStrings.FindLast(x => x[0] == 'a');
            Console.WriteLine("valor encontrado no findLast : " + valorEncontradoFinal);
            Console.WriteLine("----------------------------------------------------------");
            //fazendo uma busca no indice que atende os requisitos
            int valorNaPosição = listaStrings.FindIndex(x => x[0] == 'm'); //usando lambda
            Console.WriteLine("Valor da posição pesquisada: " + valorNaPosição);
            Console.WriteLine("----------------------------------------------------------");
            int valorNaUltimaPosição = listaStrings.FindLastIndex(Predicate); // usando um predicato
            Console.WriteLine("Valor da ultima posição pesquisada: " + valorNaUltimaPosição);
            Console.WriteLine("----------------------------------------------------------");

            //fazendo um filtro na lista
            List<string> listaFiltrada;
            listaFiltrada = listaStrings.FindAll(x => x.Length == 3);
            foreach (string elemento in listaFiltrada)
            {
                Console.WriteLine("valor filtrado por 3 caracteres : " + elemento);
            }
            Console.WriteLine("----------------------------------------------------------");

            //usando o remove
            listaStrings.Remove("joao");
            Console.WriteLine("lista sem o joao\n");
            foreach (string textos in listaStrings)
            {
                Console.WriteLine(textos);
            }
            
            Console.WriteLine("----------------------------------------------------------");
            //usando o removeAll
            listaStrings.RemoveAll(x => x.Length == 3);
            Console.WriteLine("lista sem os valores de 3 caracteres\n");
            foreach (string textos in listaStrings)
            {
                Console.WriteLine(textos);
            }
            Console.WriteLine("----------------------------------------------------------");
            //usando o removeAt
            listaStrings.RemoveAt(2);
            Console.WriteLine("lista sem o valor na posição 2(terceiro)\n");
            foreach (string textos in listaStrings)
            {
                Console.WriteLine(textos);
            }
            Console.WriteLine("----------------------------------------------------------");
            //usando o removeRange
            listaStrings.RemoveRange(1,2);
            Console.WriteLine("lista sem 2 valores a partir da posição 1\n");
            foreach (string textos in listaStrings)
            {
                Console.WriteLine(textos);
            }

            //metodo usado no find quando não é utilizado o lambda
            static bool Predicate(string s)
            {
                return s[0] == 'm';
            }
        }
    }
}