using OlaMundo.Classes;
using System.Threading.Channels;
using static System.Net.Mime.MediaTypeNames;

namespace OlaMundo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string exemplo = "Esse é UM Exemplo de TEste UMA Vez Exemplo       ";
            //Transformando a string toda em maiusculo
            string maiusculo = exemplo.ToUpper();
            Console.WriteLine(maiusculo+ " ToUpper");
            //Transformando a string toda em minusculo
            string minusculo = exemplo.ToLower();
            Console.WriteLine(minusculo+ " ToLower");
            //Removendo espaços da string
            string trim = exemplo.Trim();
            Console.WriteLine(trim+ " Trim");
            //localizando primeiros valores na string
            int localizacao = exemplo.IndexOf("UM");
            Console.WriteLine("IndexOf de UM : " + localizacao);
            //localizando ultimos valores na string
            int ultimaLocalizacao = exemplo.LastIndexOf("UM");
            Console.WriteLine("LastIndexOf de UM : " + ultimaLocalizacao);
            //Recortando valores na string
            string Recorte = exemplo.Substring(10,5);
            Console.WriteLine("Substring : " + Recorte);
            //Substituindo valores na string
            string substituicao = exemplo.Replace('e','Z');
            Console.WriteLine("substituicao : " + substituicao);
            //Substituindo valores na string
            string substituicao2 = exemplo.Replace("Exemplo", "AI IA AI IA AI IA");
            Console.WriteLine("substituicao : " + substituicao2);
            //Verificando se tem valores na string
            bool verificacao = string.IsNullOrEmpty(exemplo);
            Console.WriteLine("verificacao : " + verificacao);
            //Verificando se tem valores validos na string
            bool verificacao2 = string.IsNullOrWhiteSpace(exemplo);
            Console.WriteLine("verificacao : " + verificacao2);

        }
    }
}
