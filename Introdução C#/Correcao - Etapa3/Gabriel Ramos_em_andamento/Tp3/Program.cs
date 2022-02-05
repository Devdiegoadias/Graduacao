using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Biblioteca.Classes;

namespace Tp3
{
    class Program
    {
        static void Main(string[] args)
        {
            int opMenu;
            List<Pessoa> usuarios = new List<Pessoa>();

            Console.WriteLine("Gerenciador de Aniversários");
            opMenu = menu();
            while (opMenu != 0)
            {
                selecionaOpcao(opMenu, usuarios);
                opMenu = menu();
            }
        }

        static int menu()
        {
            int opMenu;
             
            do
            {
                Console.WriteLine("Digite uma das opções abaixo:");
                Console.WriteLine("[1] - Pesquisar pessoas");
                Console.WriteLine("[2] - Adicionar nova pessoa");
                Console.WriteLine("[0] - Sair");
                Console.Write("Digite a opção desejada: ");
                opMenu = Convert.ToInt32(Console.ReadLine());
                if ((opMenu < 0) || (opMenu > 2))
                {
                    Console.WriteLine("Opção errada");
                }
            } while ((opMenu < 0) || (opMenu > 2));
            return opMenu;
        }

        static void cadastrarUsuario(List<Pessoa> usuarios)
        {
            bool dadosOk = false;

            while (!dadosOk)
            {
                Console.Write("Digite o primeiro nome, do usuário que deseja cadastrar: ");
                string primeiroNome = Console.ReadLine();
                Console.Write("Digite o sobrenome do usuário que deseja cadastrar: ");
                string sobrenome = Console.ReadLine();
                Console.Write("Digite a data do nascimento no formato DD/MM/YYYY: ");
                string data = Console.ReadLine();
                string[] dadosData = data.Split('/');
                StringBuilder nomeCompleto = new StringBuilder(primeiroNome + " " + sobrenome);
                DateTime addAniversario = new DateTime(Int32.Parse(dadosData[2]), Int32.Parse(dadosData[1]), Int32.Parse(dadosData[0]));
                Pessoa pessoa = new Pessoa(nomeCompleto.ToString().ToUpper(), addAniversario);
                dadosOk = confirmaDados(pessoa, usuarios);
            }
        }

        static bool confirmaDados(Pessoa pessoa, List<Pessoa> usuarios)
        {
            Console.WriteLine("\nOs dados abaixo, estão corretos?");
            Console.WriteLine(pessoa.ToString());
            Console.WriteLine("[1] - Sim");
            Console.WriteLine("[2] - Não");
            int resposta = Convert.ToInt32(Console.ReadLine());
            if (resposta == 1)
            {
                usuarios.Add(pessoa);
                return true;
            }
            else
            {
                return false;
            }
        }

        static void consultaUsuario(List<Pessoa> usuarios)
        {
            Console.Write("Digite o nome, ou parte do nome, do usuário que deseja encontrar: ");
            string nome = Console.ReadLine();
            List<Pessoa> listaBusca = new List<Pessoa>();

            foreach (var p in usuarios)
            {
                if (p.nomeUsuario.Contains(nome.ToUpper()))
                {
                    listaBusca.Add(p);
                }
            }

            Console.WriteLine("Selecione uma opção abaixo para visualizar os dados de uma pessoa: ");
            for (int i = 0; i < listaBusca.Count; i++)
            {
                Console.WriteLine($"[{i}] - {listaBusca[i].nomeUsuario} ");
            }
            int opSubMenu = Convert.ToInt32(Console.ReadLine());

            for (int j = 0; j < listaBusca.Count; j++)
            {
                if (opSubMenu == j)
                {
                    Console.WriteLine(listaBusca[j]);
                    Console.WriteLine("Faltam " + listaBusca[j].calculoAniversario() + " dias para esse aniversário\n");
                }
            }
        }

        static void selecionaOpcao(int opMenu, List<Pessoa> usuarios)
        {
            switch (opMenu)
            {
                case 1:
                    if (usuarios.Any())
                    {
                        consultaUsuario(usuarios);
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Lista vazia, cadastre um Usuário primeiro.\n");
                        break;
                    }
                case 2:
                    cadastrarUsuario(usuarios);
                    break;
            }
        }
    }
}
