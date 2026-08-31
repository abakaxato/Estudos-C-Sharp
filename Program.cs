namespace OlaMundo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string sourcePath = @"C:\temp\Arquivo1.txt";
            //Lendo o arquivo fazendo 2 instanciações uma para ativar a stream do arquivo e outra para ativar a leitura
            try
            {
                using (FileStream fs = new(sourcePath, FileMode.Open))
                {
                    using (StreamReader sr = new(fs))
                    {
                        while (!sr.EndOfStream)
                        {
                            string linha = sr.ReadLine();
                            Console.WriteLine(linha);
                        }
                    }
                }
            }catch(IOException e) 
            {
                Console.WriteLine($"Ocorreu um erro : \n{e.Message}");
            }
            
            Console.WriteLine("--------------------------------------------------");

            //Lendo o arquivo fazendo apenas 1 instanciação utilizando o File para ler o arquivo diretamente
            try
            {
                using (StreamReader fs = File.OpenText(sourcePath))
                {
                    while (!fs.EndOfStream)
                    {
                        string linha = fs.ReadLine();
                        Console.WriteLine(linha);
                    }
                }
            }catch(IOException e) 
            {
                Console.WriteLine($"Ocorreu um erro : \n{e.Message}");
            }
        }
    }
}
