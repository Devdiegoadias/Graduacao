using Armazenamento_Memoria;
using Cadastro_Biblioteca;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TP3_Emanoele_Souza__Gerenciador_de_Aniversario
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Gerenciador de Aniversário";            
            var sair = false;
            while (sair == false)
            {
                Console.WriteLine("\n*** MENU PRINCIPAL ***\nEscolha um número que representa as opções abaixo:\n");
                Console.WriteLine("[ 1 ] - Fazer uma busca detalhada");
                Console.WriteLine("[ 2 ] - Adicionar novas Pessoas");
                Console.WriteLine("[ 3 ] - Alterar ou excluir pessoas");
                Console.WriteLine("[ 0 ] - Cancelar\n");
                switch (Console.ReadLine())
                {
                    case "1":
                        Repositorio.EncontrarPessoa();
                        break;
                    case "2":
                        MenuCadastro.AdicionarPessoa();
                        break;
                    case "3":
                        var voltar = false;
                        if (voltar == false)
                        {
                            Console.WriteLine("\nEscolha uma das opções:\n[ 1 ] - Excluir Informações, [ 2 ] - Editar Informações ou [ 0 ] - Voltar ao menu principal\n");
                            switch (Console.ReadLine())
                            {
                                case "1":
                                    Repositorio.ExclusaoPessoa();
                                    break;
                                case "2":
                                    Repositorio.Editar();
                                    break;
                                case "0":
                                    voltar = true;
                                    break;
                                default:
                                    Console.WriteLine("Por favor, escolha uma das opções apresentadas");
                                    break;
                            }
                        }
                        break;
                    case "0":
                        sair = true;
                        break;
                    default:
                        Console.WriteLine("Por favor, escolha uma opção válida");
                        break;
                }                
            }            
        }
    }
}
