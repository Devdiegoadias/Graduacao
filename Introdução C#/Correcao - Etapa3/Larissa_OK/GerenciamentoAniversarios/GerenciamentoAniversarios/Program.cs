using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Biblioteca.Classes;

namespace GerenciamentoAniversarios
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Gerenciador de aniversário");
            
            List<Pessoa> pessoas = new List<Pessoa>();
            int opcao;
            opcao = Menu();
            while(opcao != 3)
            {
                OpcaoSelecionada(opcao, pessoas);
                opcao = Menu();
            }
        }

        public static int Menu()
        {
            int opcao;
            do
            {
                Console.WriteLine("");
                Console.WriteLine("Selecione uma das opções abaixo:");
                Console.WriteLine("1 - Adicionar nova pessoa");
                Console.WriteLine("2 - Pesquisar pessoas");
                Console.WriteLine("3 - Sair");
                opcao = Convert.ToInt16(Console.ReadLine());
                if (opcao < 0 || opcao > 3)
                {
                    Console.WriteLine("Opção incorreta.");
                }
            } while (opcao < 0 || opcao > 3);
            return opcao;
            
        }

        public static void OpcaoSelecionada(int opcao, List<Pessoa> pessoas)
        {
            switch (opcao)
            {
                case 1:
                    CadastrarPessoa(pessoas);
                    break;

                case 2:
                    if (pessoas.Any())
                    {
                        ConsultarPessoa(pessoas);
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Sem pessoas cadastradas. Favor inserir novo usuário.");
                        break;
                    }
            }
        }

        public static void CadastrarPessoa(List<Pessoa> pessoas)
        {
            bool Confirmado = false;

            while (!Confirmado)
            {
                Console.Write("Digite o nome: ");
                string nome = Console.ReadLine();
                Console.Write("Digite o sobrenome: ");
                string sobrenome = Console.ReadLine();
                Console.Write("Digite a data do nascimento no formato YYYY/MM/DD: ");
                DateTime nascimento = Convert.ToDateTime(Console.ReadLine());
                Pessoa p = new Pessoa(nome, sobrenome, nascimento);
                Confirmado = DadosConfirmados(p, pessoas);
            }
        }

        public static bool DadosConfirmados(Pessoa p, List<Pessoa> pessoas)
        {
            Console.WriteLine("");
            Console.WriteLine("Os dados cadastrados estão corretos?");
            Console.WriteLine($"Nome: {p.Nome} {p.Sobrenome}");
            Console.WriteLine($"Data de nascimento: {p.Aniversario.Day}/{p.Aniversario.Month}/{p.Aniversario.Year}");
            Console.WriteLine("[1] - Sim");
            Console.WriteLine("[2] - Não");
            int resposta = Convert.ToInt32(Console.ReadLine());
            if (resposta == 1)
            {
                pessoas.Add(p);
                return true;
            }
            else
            {
                return false;
            }
        }

        public static void ConsultarPessoa(List<Pessoa> pessoas)
        {
            Console.WriteLine("Digite o nome ou parte do nome que deseja: ");
            string keyword = Console.ReadLine();
            List<Pessoa> resultado = new List<Pessoa>();

            foreach(var p in pessoas)
            {
                if(p.Nome.Contains(keyword) || p.Sobrenome.Contains(keyword)) 
                {
                    resultado.Clear();
                    resultado.Add(p); 
                }
            }

            Console.WriteLine("Selecione uma opção abaixo para visualizar os dados de uma pessoa: ");
            for (int i = 0; i < resultado.Count; i++)
            {
                Console.WriteLine($"[{i}] - {resultado[i].Nome} {resultado[i].Sobrenome}");
            }
            int opSubMenu = Convert.ToInt32(Console.ReadLine());

            for (int j = 0; j < resultado.Count; j++)
            {
                if (opSubMenu == j)
                {
                    Console.WriteLine(resultado[j]);
                    Pessoa.ProxAniversario(resultado[j].Aniversario);
                }
            }
        }
    }
}
