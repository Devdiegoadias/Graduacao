using Armazenamento_Memoria;
using Pessoa_Model_Biblioteca;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;

namespace Cadastro_Biblioteca
{
    class CadastrarPessoas : Repositorio, ICadastro
    {
        public void CadastroPessoa()
        {
            var lerNome = LerDadosConsole("\nDigite o nome da pessoa:\n");
            var lerSobreNome = LerDadosConsole("\nDigite o sobrenome da pessoa:\n");
            var lerdata = LerDadosConsole($"\nPor favor digite a data de nascimento de {lerNome} no formato [ dd/MM/yyyy ]:\n");
            bool cancelar = false;
            if(cancelar == false)
            {
                Console.WriteLine("Os dados abaixo estão corretos?");
                Console.WriteLine($"\nNome completo: {lerNome} {lerSobreNome}\n\nData do nascimento: {lerdata}\n\nDigite [ s ] - para sim, caso o contrario [ n ] - para não\n");
                switch (Console.ReadLine().ToLower())
                {
                    case "s":
                        if(DateTime.TryParseExact(lerdata, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out _))
                        {
                            pessoas.Add(new Pessoa()
                            {
                                Nome = lerNome.ToUpperInvariant(),
                                SobreNome = lerSobreNome.ToUpperInvariant(),
                                DataAniversario = DateTime.ParseExact(lerdata, "dd/MM/yyyy", CultureInfo.InvariantCulture)
                            });
                            Console.WriteLine("*** Pessoa adicionada com sucesso! ***\n");
                        }
                        else
                        {
                            Console.WriteLine("\n[ ERRO: ] - Por favor! Digite a data no formato [ dd/MM/yyy ] e tente novamente\n");
                        }
                        break;
                    case "n":
                        cancelar = true;
                        break;
                    default:
                        Console.WriteLine("\n[ ERRO: ] - Digite uma opção válida!\n");
                        break;
                }
            }
        }
    }
}
