//Exercicio da aula 150


#region Enunciado da questao
/*

*/
#endregion Enunciado da questao


using OlaMundo.Classes.EqualsHashCode;
using OlaMundo.Classes.Generics;
using OlaMundo.Exercicios.Aula144.Interfaces;
using OlaMundo.Exercicios.Aula144.Service;
using System.Globalization;

namespace OlaMundo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Criando um conjunto hashSet

            Console.WriteLine("Criando um conjunto hashSet");
            HashSet<String> conjuntoHashSet = new();
            //Adicionando valores
            conjuntoHashSet.Add("Televisão");
            conjuntoHashSet.Add("Notebook");
            conjuntoHashSet.Add("Video game");
            conjuntoHashSet.Add("Computador");

            //Verificando se existe o valor selecionado dentro do conjunto
            Console.WriteLine(conjuntoHashSet.Contains("Televisão"));

            //percorrendo o conjunto
            foreach (string produtos in conjuntoHashSet)
            {
                Console.WriteLine(produtos);
            }

            Console.WriteLine("--------------------------------------");

            Console.WriteLine("Criando o segundo conjunto hashSet");
            HashSet<string> conjuntoHashSet2 = new(conjuntoHashSet);
            Console.WriteLine("Percorrendo o segundo conjunto criado a partir do primeiro");
            foreach (string produtos in conjuntoHashSet2)
            {
                Console.WriteLine(produtos);
            }

            Console.WriteLine("--------------------------------------");

            //Criando um conjunto SortedSet
            Console.WriteLine("Criando um conjunto SortedSet");

            SortedSet<String> conjuntoSortedSet = new();
            //Adicionando valores
            conjuntoSortedSet.Add("Cadeira");
            conjuntoSortedSet.Add("Sofa");
            conjuntoSortedSet.Add("Poltrona");
            conjuntoSortedSet.Add("Banco");
            conjuntoSortedSet.Add("Computador");

            //Verificando se existe o valor selecionado dentro do conjunto
            Console.WriteLine(conjuntoSortedSet.Contains("Poltrona"));

            //percorrendo o conjunto
            foreach (string produtos in conjuntoSortedSet)
            {
                Console.WriteLine(produtos);
            }

            //Fazendo a união de conjuntos (insere apenas os valores que existem em um mas não no outro)
            //Fiz a união de 2 conjuntos diferentes, o hash agr tem os valores do sorted dentro dele
            Console.WriteLine("--------------------------------------");

            Console.WriteLine("Fazendo a união de 2 conjuntos, um HashSet e outro SortedSet dentro de um HashSet");
            conjuntoHashSet.UnionWith(conjuntoSortedSet);

            foreach (string produtos in conjuntoHashSet)
            {
                Console.WriteLine(produtos);
            }

            //Fazendo a interseção de conjuntos (Deixa apenas os valores que existem nos 2 conjuntos)
            //Fiz a interseção de 2 conjuntos diferentes, o sorted agr tem os apenas os valores que também existiam no hash
            Console.WriteLine("--------------------------------------");

            Console.WriteLine("Fazendo a interseção de 2 conjuntos, um HashSet e outro SortedSet dentro de um SortedSet");
            conjuntoSortedSet.IntersectWith(conjuntoHashSet2);

            foreach (string produtos in conjuntoSortedSet)
            {
                Console.WriteLine(produtos);
            }

            //Fazendo a diferença de conjuntos (Deixa apenas os valores que existem no primeiro conjunto retirando os que também aparecem no segundo conjunto)
            //Fiz a diferença de 2 conjuntos diferentes, o hash agr tem os apenas os valores que são exclusivos e não existiam no hash
            Console.WriteLine("--------------------------------------");

            Console.WriteLine("Fazendo a diferença de 2 conjuntos, um HashSet e outro SortedSet dentro de um hashSet");
            conjuntoHashSet2.ExceptWith(conjuntoSortedSet);

            foreach (string produtos in conjuntoHashSet2)
            {
                Console.WriteLine(produtos);
            }
        }
    }
}
