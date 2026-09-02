using System.Data.SqlTypes;
using System.Security.AccessControl;

namespace OlaMundo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string sourcePath = @"C:\temp\pasta com arquivos\subpasta com arquivos\arquivo1.txt";

            //Estudando a classe Path
            {
                //Metodo para puxar o path completo de um path parcial
                Console.WriteLine("GetFullPath : " + Path.GetFullPath(sourcePath));
                //Metodo para puxar apenas o path
                Console.WriteLine("GetDirectoryName : " + Path.GetDirectoryName(sourcePath));
                //Metodo para puxar o nome do arquivo sem a extensão do arquivo
                Console.WriteLine("GetFileNameWithoutExtension : " + Path.GetFileNameWithoutExtension(sourcePath));
                //Metodo para puxar a extensão do arquivo
                Console.WriteLine("GetExtension : " + Path.GetExtension(sourcePath));
                //Metodo para puxar a pasta temporaria do meu sistema atual
                Console.WriteLine("GetTempFileName : " + Path.GetTempFileName());
            }
        }
    }
}
