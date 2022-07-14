using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Let_s_Speak
{
    internal class MenuGeneral
    {
        public static void Menu()
        {
            var menu = new MenuItem("Menu Principal");

            var englishWords = new MenuItem("Palavras em Inglês");
            englishWords.Add(new MenuItem("Cadastrar Palavras", EnglishDictionary.Add));
            englishWords.Add(new MenuItem("Listar Palavras", EnglishDictionary.ListOfWords));
            //englishWords.Add(new MenuItem("Editar Palavras", Produto.EditarProduto));
            englishWords.Add(new MenuItem("Remover Palavras", EnglishDictionary.Remove));
            englishWords.Add(new MenuItem("Procurar Palavras", EnglishDictionary.Search));

            //var produtos = new MenuItem("Palavras em Espanhol");
            //produtos.Add(new MenuItem("Cadastrar Palavras", Produto.CadastrarProdutos));
            //produtos.Add(new MenuItem("Listar Palavras", Produto.ListarProdutos));
            //produtos.Add(new MenuItem("Editar Palavras", Produto.EditarProduto));
            //produtos.Add(new MenuItem("Remover Palavras", Produto.RemoverProduto));
            //produtos.Add(new MenuItem("Procurar Palavras", Produto.ProcurarProduto));

            //var produtos = new MenuItem("Palavras em Francês");
            //produtos.Add(new MenuItem("Cadastrar Palavras", Produto.CadastrarProdutos));
            //produtos.Add(new MenuItem("Listar Palavras", Produto.ListarProdutos));
            //produtos.Add(new MenuItem("Editar Palavras", Produto.EditarProduto));
            //produtos.Add(new MenuItem("Remover Palavras", Produto.RemoverProduto));
            //produtos.Add(new MenuItem("Procurar Palavras", Produto.ProcurarProduto));

            menu.Add(englishWords);
            //menu.Add(funcionarios);
            //menu.Add(clientes);
            //menu.Add(vendas);
            menu.Add(new MenuItem("Sair", () => Environment.Exit(0)));

            menu.Execute();
        }
    }
}
