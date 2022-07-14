using Let_s_Speak;
using Sharprompt;

namespace LetsSpeak
{
    public class Program
    {
        static void Main()
        {
            ConfiguraPrompt();
            Console.Title = "Let's Speak";
            MenuGeneral.Menu();
        }

        private static void ConfiguraPrompt()
        {
            Prompt.ColorSchema.Answer = ConsoleColor.White;
            Prompt.ColorSchema.Select = ConsoleColor.White;

            Prompt.Symbols.Prompt = new Symbol("", "");
            Prompt.Symbols.Done = new Symbol("", "");
            Prompt.Symbols.Error = new Symbol("", "");
        }

    }
}