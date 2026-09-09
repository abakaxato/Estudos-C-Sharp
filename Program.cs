//Exercicio da aula 150


#region Enunciado da questao
/*

*/
#endregion Enunciado da questao



using OlaMundo.Classes.EqualsHashCode;

namespace OlaMundo
{
    internal class Program
    {
        static void Main(string[] args)
        {
        
            //Testando equals e hashCode personalizados
            Materia areiaBranca = new()
            {
                Cor = "Branca",
                Peso = 0.01,
                Nome = "Areia"
            };
            Console.WriteLine(areiaBranca.ToString());

            Materia areiaMarrom = new()
            {
                Cor = "Marrom",
                Peso = 0.01,
                Nome = "Areia"
            };
            Console.WriteLine(areiaMarrom.ToString());

            Materia lamaMarrom = new()
            {
                Cor = "Marrom",
                Peso = 0.50,
                Nome = "Lama Marrom"
            };
            Console.WriteLine(lamaMarrom.ToString());
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine("Testando se a areia branca é igual a areia marrom usando o equals (Nome e Peso)");
            Console.WriteLine(areiaBranca.Equals(areiaMarrom));
            Console.WriteLine("Testando se a lama marrom é igual a areia marrom usando o equals (Nome e Peso)");
            Console.WriteLine(lamaMarrom.Equals(areiaMarrom));
            Console.WriteLine("Testando se a lama marrom é igual a areia marrom usando o cashCode (hashCode da cor)");
            Console.WriteLine("hash Code da lama marrom : " + lamaMarrom.GetHashCode());
            Console.WriteLine(lamaMarrom.GetHashCode() == areiaMarrom.GetHashCode());
            Console.WriteLine("----------------------------------------------");
            //Fazendo uma chamada de método padrão do C# que vai utilizar a minha implementação do getHashCode e do Equals
            //Se eu não tivesse implementado a comparação iria considerar a referencia em memoria como o obj de comparação

            //Criando outra areia branca
            Materia areiaBrancaCopia = new()
            {
                Cor = "Branca",
                Peso = 0.01,
                Nome = "Areia"
            };
            //Criando um conjunto hashSet de Materia
            HashSet<Materia> materiaHashSet = new();
            //Adicionando uma copia da areia branca no conjunto (Não é a areia branca e ocupa um lugar diferente da areia branca em memoria)
            materiaHashSet.Add(areiaBrancaCopia);
            //Verificando se existe areia branca na lista
            Console.WriteLine("Verificando se existe areia branca na lista");
            Console.WriteLine(materiaHashSet.Contains(areiaBranca));

        }
    }
}
