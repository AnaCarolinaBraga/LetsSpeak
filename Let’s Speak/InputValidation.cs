
namespace Let_s_Speak
{
    internal class InputValidation
    {
        public static bool WordValidation(string wordValidation)
        {
            bool valido = true;
            if (wordValidation.Contains("?") || wordValidation.Contains("*"))
            {
                Console.WriteLine("Caracteres inválidos.");
                return valido = false;
            }
            return valido;
        }
    }
}
