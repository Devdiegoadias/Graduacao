using System;
using System.Collections;
using System.Collections.Generic;

namespace TP3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Pessoa> listapessoa = new List<Pessoa>();
            List<string> listanome = new List<string>();

            int escolha;

            do
            {
                escolha = verifica();
                switch (escolha)
                {
                    case 1:
                        VerificarLista(listapessoa, listanome);
                        break;
                    case 2:
                        addPessoa(listapessoa);
                        break;
                    case 3:
                        return;
                }
            } while (true);
        }
        static int verifica()
        {
            int escolha;
            Console.WriteLine("Gerenciador de Aniversários");
            Console.WriteLine("Selecione uma das opções abaixo:");
            Console.WriteLine("1 - Pesquisar pessoas");
            Console.WriteLine("2 - Adicionar nova pessoa");
            Console.WriteLine("3 - Sair");
            escolha = Convert.ToInt32(Console.ReadLine());
            return escolha;
        }

        static void addPessoa(List<Pessoa> listapessoa)
        {
            Console.WriteLine("Gerenciador de Aniversários");
            Console.WriteLine("Digite o nome da pessoa que deseja adicionar: ");
            string nome = Console.ReadLine();
            Console.WriteLine("Digite o sobrenome da pessoa que deseja adicionar: ");
            string sobrenome = Console.ReadLine();
            Console.WriteLine("Digite a data de aniversário no fomato dd/MM/YYYY: ");
            DateTime aniver = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Os dados abaixo estão corretos?");
            Console.WriteLine("Nome:" + nome + " " + sobrenome);
            Console.WriteLine("Data de aniversário:" + aniver);
            Console.WriteLine("1 - Sim");
            Console.WriteLine("2 - Não");
            int escolha = Convert.ToInt32(Console.ReadLine());
            if (escolha == 1)
            {
                Pessoa novo = new Pessoa(nome, sobrenome, aniver);
                listapessoa.Add(novo);
                Console.WriteLine("Dados adicionados com sucesso!");
            }
            else
            {
                addPessoa(listapessoa);
            }
        }
        static void VerificarLista(List<Pessoa> listapessoa, List<string> listanome)
        {
            Console.WriteLine("Gerenciador de Aniversários");
            Console.WriteLine("Digite o nome, ou parte do nome, da pessoa que deseja encontrar:"); //contains()
            string nome = Console.ReadLine();

            for (int m = 0; m <= listapessoa.Count - 1; m++)
            {
                if (listapessoa[m].Nome.Contains(nome))
                {
                    listanome.Add(listapessoa[m].Nome);
                }
                foreach (string b in listanome)
                {
                    Console.WriteLine(b);
                }

                DateTime today = DateTime.Today;
                for (int z = 0; z <= listapessoa.Count - 1; z++)
                {
                    if (nome == listapessoa[z].Nome)
                    {
                        int d3 = (int)(today - listapessoa[z].data).TotalDays;
                        Console.WriteLine("Dados da pessoa:");
                        Console.WriteLine("Nome Completo: " + listapessoa[z].Nome + " " + listapessoa[z].Sobrenome);
                        Console.WriteLine("Data do Aniversário: " + listapessoa[z].data);
                        Console.WriteLine("Faltam " + d3 + " dias para esse aniversário.");
                    }
                }
            }
        }
    }
}
