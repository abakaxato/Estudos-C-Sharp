//Exercicio da aula 159


#region Enunciado da questao
/*

*/
#endregion Enunciado da questao

using OlaMundo.Exercicios.Aula116;

namespace OlaMundo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Criando os valores para lista
            List<Product> products =
            [   new Product("Oculos", 800.85),
                new Product("Computador",5600.75),
                new Product("Uniforme",2100.55),
                new Product("Zebra",67.67),
                new Product("Alicate",200.82),
                new Product("Ovelha", 800.85),
                
            ];
            
            Console.WriteLine("Produtos : ");
            products.ForEach(Console.WriteLine);
            Console.WriteLine("----------------");

            //utilizando a função Sum do Linq para fazer a soma do atributo price dos objetos
            double min = products.Min(product => product.Price);
            Console.WriteLine($"minimo dos preços usando min : {min}");

            //utilizando a função Sum do Linq para fazer a soma do atributo price dos objetos
            double max = products.Max(product => product.Price);
            Console.WriteLine($"maximo dos preços usando Max : {max}");

            //utilizando a função Sum do Linq para fazer a soma do atributo price dos objetos
            double sum = products.Sum(product => product.Price);
            Console.WriteLine($"Soma dos preços usando Sum : {sum}");

            //utilizando a função Sum do Linq para fazer a soma do atributo price dos objetos
            double avg = products.Average(product => product.Price);
            Console.WriteLine($"média dos preços usando Average : {avg}");

            Console.WriteLine("----------------");

            //utilizando a função Aggregate do Linq para fazer a agregação personalizada do atributo Name dos objetos
            //Primeiro eu tenho que isolar a coleção para virar uma coleção de Nomes, faço isso usando o Select
            //Depois passo 2 argumentos como parâmetros que vão ser os "Valor atual e o proximo" durante a agregação
            //Depois eu falo o que vai acontecer a cada nova iteração da coleção

            //Nesse caso eu estou juntando a primeira letra de cada nome dos produtos
            //Nos testes descobri que ele considera o primeiro produto no primeiro argumento, mas no segundo argumento são todos os outros produtos
            //Colocando o "" antes dos argumentos eu usei uma sobreposição do método Aggregate onde você pode inserir o valor inicial da agregação
            //Assim fazendo o product ser "" e o product2 serem os primeiros caracteres do atributo Name de produto
            var agg = products.Select(product => product.Name).Aggregate("",(product,product2)=> product + product2[0]);
            Console.WriteLine($"Agregação dos nomes usando Aggregate : \n{agg}");

            //utilizando a função GroupBy do Linq para fazer o agrupamento dos atributos pelos price dos objetos
            var group = products.GroupBy(product => product.Price);

            Console.WriteLine($"agrupamentyo dos preços usando GroupBy :");

            //Para percorrer uma coleção do tipo IGrouping que é o retorno do groupBy é necessario seguir esse padrão de foreach
            //O primeiro argumento é o valor que vai ser utilizado como referencia para o agrupamento (que já foi feito no groupBy), o segundo são os valores a serem agrupados
            //O foreach externo percorre cada grupo criado (ex: "Grupo do Preço 100", "Grupo do Preço 200").
            //O foreach interno percorre os itens que estão guardados dentro daquele grupo específico(Product).
            //Poderia ser um var no lugar do IGrouping<double, Product>
            foreach (IGrouping<double, Product> item in group)
            {
                Console.WriteLine($"Divisão por preço");
                foreach (Product product in item)
                {
                    Console.WriteLine(product);
                }
                Console.WriteLine();
            }
        }
    }
}
