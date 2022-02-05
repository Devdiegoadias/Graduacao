using BlibioPessoas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP3_GerenciadorAniversario
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Pessoa> lista_pessoas = new List<Pessoa>();
            Menu(lista_pessoas);
        }

        public static void Menu(List<Pessoa> lista_pessoas)
        {
            while (true)
            {
                Console.WriteLine("\n---------------------------");
                Console.WriteLine("GERENCIADOR DE ANIVERSÁRIOS");
                Console.WriteLine("---------------------------\n");

                Console.WriteLine("Digite uma das opções abaixo:");
                Console.WriteLine("1 - Pesquisar pessoas\n2 - Adicionar pessoa\n3 - Sair");

                int escolhaMenu = int.Parse(Console.ReadLine());

                if (escolhaMenu == 1)
                {
                    Console.Clear();
                    PesquisarPessoa(lista_pessoas);
                }
                else if (escolhaMenu == 2)
                {
                    Console.Clear();
                    AdicionarPessoa(lista_pessoas);
                }
                else if (escolhaMenu == 3)
                {
                    Console.Clear();
                    Console.WriteLine("Sair do sistema\nAté logo!");
                    break;
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Opção inválida!\nTente novamente");
                }
            }
        }

        public static void AdicionarPessoa(List<Pessoa> lista_pessoas)
        {
            string nome, sobrenome;
            DateTime nascimento;

            Console.WriteLine("\n----------------");
            Console.WriteLine("ADICIONAR PESSOA");
            Console.WriteLine("----------------\n");

            Console.WriteLine("Digite o nome:");
            nome = Console.ReadLine();
            Console.WriteLine("Digite o sobrenome;");
            sobrenome = Console.ReadLine();
            Console.WriteLine("Digite a data de nascimento: dd/mm/aaaa");
            nascimento = DateTime.Parse(Console.ReadLine());

            Console.WriteLine("\nOs dados abaixo estão correto?\n1 - Sim\n2 - Não\n");
            Console.WriteLine("Nome: " + nome + "\nSobrenome: " + sobrenome + "\nData de nascimento: " + nascimento);
            int opcao = int.Parse(Console.ReadLine());

            if (opcao == 1)
            {
                Pessoa nova_pessoa = new Pessoa(nome, sobrenome, nascimento);
                lista_pessoas.Add(nova_pessoa);
                Console.WriteLine("Adicionado com sucesso!");

            }
            else if (opcao == 2)
            {
                Console.WriteLine("\nAdição cancelada!\nTente novamente para adicionar essa pessoa.");
            }
        }

        public static void PesquisarPessoa(List<Pessoa> lista_pessoas)
        {
            List<Pessoa> lista_aux_pessoas = new List<Pessoa>();
            int count = 0, opPessoa;

            Console.WriteLine("Digite o nome:");
            string procuraNome = Console.ReadLine();

            foreach (var pessoa in lista_pessoas)
            {
                string nomeCompleto = pessoa.Nome + " " + pessoa.Sobrenome;
                if (nomeCompleto.Contains(procuraNome))
                {
                    lista_aux_pessoas.Add(pessoa);
                }
            }

            Console.WriteLine("\nSelecione uma das opções abaixo para visualizar os dados da pessoa:");

            foreach (var t in lista_aux_pessoas)
            {
                Console.WriteLine($"[{count++}] - " + t.Nome + " " + t.Sobrenome);
            }

            opPessoa = int.Parse(Console.ReadLine());

            Console.WriteLine(lista_aux_pessoas[opPessoa]);
            Console.WriteLine("O tempo que falta para o próximo aniversário é: " + lista_aux_pessoas[opPessoa].CalcularDataProximoAniversario());
        }
    }
}
