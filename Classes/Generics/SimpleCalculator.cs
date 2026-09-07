namespace OlaMundo.Classes.Generics
{
    //Declarando a classe com um tipo generico U (Poderia ser qualquer letra)
        //Fiz isso apenas para deixar explicito que podem ser declarados varios generics
            //Um esta declarado na classe e outro no método
                //Esse da classe vai ser obrigado a ser um tipo struct
    internal class SimpleCalculator<U>(U u)where U : struct
    {
        //Declarando um método que vai retornar o tipo de dado que foi setado no generics U
            //Apenas vai escrever no console o tipo de dado colocado na instanciação da classe
        public void GenericTypeOfClass() {
            Console.WriteLine($"Tipo selecionado na instanciação da classe {u.GetType()}");
        }


        //Declarando um método que recebe um tipo generico T
            //Esse tipo tem que ser especificado na chamada desse método
                //Esse tipo tem que ser um tipo que tenha o "IComparable" implementado
        public void Calc<T>(T a, T b) where T : IComparable
        {
            //Utilizando o "CompareTo" original
                //Ele retorna
                    //0 se os valores forem iguais
                    //1 se o valor do chamador "a" for maior que o do parametro "b"
                    //-1 se o valor do parametro "b" for maior que o chamador "a"

            if (a.CompareTo(b) > 0)
            {
                Console.WriteLine($"resultado do CompareTo : {a.CompareTo(b)}\n{a} é maior que {b}");

            }else if (a.CompareTo(b) == 0)
            {
                Console.WriteLine($"resultado do CompareTo : {a.CompareTo(b)}\n{a} é igual a {b}");
            }
            else
            {
                Console.WriteLine($"resultado do CompareTo : {a.CompareTo(b)}\n{a} é menor que {b}");
            }
        }
    }
}
