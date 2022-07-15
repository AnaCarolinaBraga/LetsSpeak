
namespace Let_s_Speak
{
    internal class InputValidation
    {
        public static bool WordValidation(string wordSearch)
        {
            bool valido = true;
            if (wordSearch.Contains("?") || wordSearch.Contains("*"))
            {
                Console.WriteLine("Caracteres inválidos.");
                return valido = false;
            }
            return valido;
        }
    }
}
