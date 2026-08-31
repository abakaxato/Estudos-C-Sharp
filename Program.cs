namespace OlaMundo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string sourcePath = @"C:\temp\Arquivo1.txt";
            string targetPath = @"C:\temp\Arquivo2.txt";
            try
            {
                string[] lines = File.ReadAllLines(sourcePath);
                using StreamWriter sw = File.AppendText(targetPath);
                foreach(string line in lines)
                {
                    sw.WriteLine(line.ToUpper());
                }
            }
            catch (IOException e)
            {
                Console.WriteLine($"Ocorreu um erro : \n{e.Message}");
            }


            
        }
    }
}
