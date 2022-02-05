using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cadastro_Biblioteca
{
    public class MenuCadastro
    {
        public static void AdicionarPessoa()
        {
            CadastrarPessoas cadastrarPessoas = new CadastrarPessoas();
            var sair = false;
            while(sair == false)
            {
                Console.WriteLine("\n*** MENU CADASTRO ***\nDeseja adicionar uma nova Pessoa?\n Digite [ s ] - para sim ou [ n ] - para não\n");
                switch (Console.ReadLine().ToLower())
                {
                    case "s":
                        cadastrarPessoas.CadastroPessoa();
                        break;
                    case "n":
                        sair = true;
                        break;
                    default:
                        Console.WriteLine("\nDigite uma opção válida!\n");
                        break;
                }
            }
        }
    }
}
