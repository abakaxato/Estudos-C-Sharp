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
            //Predicate
            //Delegate que espera um método que receba um valor e retorne um bool
            {
                //Criando uma lista de inteiros
                List<int> numeros = [22, 4, 5, 12, 15, 77, 44, 13, 22];
                //Fazendo um RemoveAll na lista criada utilizando uma expressão lambda
                //no lugar do método com assinatura predicate que deveria ser passado como parâmetro
                numeros.RemoveAll(numero => numero > 50);
                //printando os valores da lista apos a remoção
                foreach (var item in numeros)
                {
                    Console.WriteLine(item);
                }
            }
            
            Console.WriteLine("--------------------------------------");

            //Action
            //Delegate que espera um método void que receba ate 16 parametros, ou seja, quer que seja associado a um método que faça algo, mas não retorne nada
            {
                //Criando uma lista de string
                List<string> palavras = ["Bola","Carro","Limão","Computador"];
                //Fazendo um ForEach na lista criada utilizando um método que encaixe com a assinatura Action que deve ser passado como parâmetro do ForEach
                
                //método  de print utilizado no ForEach do Action
                static void AdicaoDeTexto(string n)
                {
                    Console.WriteLine(n + " Texto adicionado Action");
                }

                //Associação do método ao delegate
                Action<string> action = AdicaoDeTexto;
                
                //passando o delegate como parâmetro do ForEach
                palavras.ForEach(action);
                
            }
            
            Console.WriteLine("--------------------------------------");
            
            //Func
            //Delegate que espera um método com um retorno <T> que recebe ate 16 parametros
            {
                //Criando uma lista de string
                List<string> palavras = ["Bola","Carro","Limão","Computador"];

                //método utilizado no ForEach do Action
                static string Mudançadetexto(string texto)
                {
                    texto += " Texto Adicionado Func";
                    return texto.ToUpper();
                }

                //Associando um método com a assinatura correta ao delegate Func
                Func<string, string> func = Mudançadetexto;

                //Fazendo um Select na lista criada utilizando um método que encaixe com a assinatura Func que deve ser passado como parâmetro do select
                // O select retorna um IEnumerable, estou dando um UPscale e associando o valor a uma nova lista
                List<string> novaLista = palavras.Select(func).ToList();

                //printando a nova lista (por baixo dos panos estou utilizando o delegate Action no ForEach)
                novaLista.ForEach(item => Console.WriteLine(item));
                Console.WriteLine("--------------------------");
                //Testando com uma expressão lambda ao inves do método
                List<string> novaListaLambda = palavras.Select((palavra => palavra + "Texto adicionado na lambda")).ToList();
                novaListaLambda.ForEach(item => Console.WriteLine(item));
            }
            
        }
    }
}
