//Mudando o namespace para que ele fique no mesmo nivel do 
// item que esta sendo extendido, assim deixando o método extendido
// disponivel para todos que chamarem o seu dono
namespace System
{
    static internal class StringExtension
    {
        //Extendendo um novo método para o objeto do tipo "string",
        //agora onde eu criar uma string eu posso usar o método abaixo

        //Método que retorna o antepenultimo valor em uma string
        public static string ThirdToLastWord(this string thisObj,string split = " ") 
        {
            string[] text = thisObj.Split(split);

            if (text.Length < 3)
            {
                return "this object is too small";
            }
            else
            {
                int wordPosition = text.Length - 3;
                return text[wordPosition];
            }
        }
    }
}
