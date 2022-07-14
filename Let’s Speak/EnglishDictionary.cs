using BetterConsoleTables;
using Sharprompt;
using System.ComponentModel.DataAnnotations;
using static Let_s_Speak.Database;
using System.IO;

namespace Let_s_Speak
{
    public class EnglishDictionary
    {
        [Display(Name = "Palavra em inglês")]
        [Required(ErrorMessage = "A palavra é obrigatória")]
        public string Palavra { get; set; }

        [Display(Name = "Tradução")]
        [Required(ErrorMessage = "A tradução é obrigatória")]
        public string Traducao { get; set; }

        public static void Add()
        {
            var englishWord = Prompt.Bind<EnglishDictionary>();

            if (!Prompt.Confirm("Deseja Salvar?"))
                return;

            Database.englishDictionary.Add(englishWord);
            Database.Save(DatabaseOption.englishDictionary);
        }

        public static void ListOfWords()
        {
            Console.WriteLine("Listando Palavras");
            Console.WriteLine();

            var table = new Table(TableConfiguration.UnicodeAlt());
            table.From(Database.englishDictionary);
            Console.WriteLine(table.ToString());
        }

        public static void Remove()
        {
            var wordRemove = Prompt.Select("Selecione a palavra para Remover:", Database.englishDictionary);
            var confirm = Prompt.Confirm("Tem Certeza?", false);

            if (!confirm)
                return;

            Database.englishDictionary.Remove(wordRemove);
            Database.Save(DatabaseOption.englishDictionary);
        }

        public static void Search()
        {
            Console.WriteLine("Qual a palavra ou termo que você deseja procurar?");
            string wordSearch = Console.ReadLine();
            Database.Search(wordSearch);
        }

    }
}
