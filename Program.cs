//Exercicio da aula 159


#region Enunciado da questao
/*

*/
#endregion Enunciado da questao

namespace OlaMundo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Estudo de linq

            //Criando um dataSource
            int[] numbers = [12,44,50,23,45,13,88];

            //Utilizando a função where (filtra os valores atraves de um método bool) utilizando o delegate Predicate
            List<int> numberWhere = numbers.Where(number => (number % 2) == 0).ToList();
            numberWhere.ForEach(Console.WriteLine);
            
            Console.WriteLine("--------------------");

            //Utilizando a função Select (cria uma nova lista atraves de um método que recebe X valores e retorne 1 valor) utilizando o delegate Func
            List<int> numbersSelect = numbers.Select(number => { if (number % 2 == 0) { return number * 10; } else { return number; } }).ToList();
            numbersSelect.ForEach(Console.WriteLine); //Printando os valores da nova lista feita a partir do select
            
        }
    }
}
