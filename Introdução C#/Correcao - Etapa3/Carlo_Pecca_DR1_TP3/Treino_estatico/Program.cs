using ClassLibrary1;

namespace TreinoEstatica
{
    class Program
    {
        static void Main()
        {
            Repositoriodepessoa pessoaList = new();
            Mensagem m = new();
            int num_resposta = 0;
            pessoaList.Adicionar("Joao", "Joao", new(1992, 04, 14));
            pessoaList.Adicionar("Jose", "Silva", new(1994, 02, 20));
            while (num_resposta == 0 || num_resposta != 3)
            {
                Console.Write(m.principal());
                try
                {
                    string resposta = Console.ReadLine();
                    num_resposta = Convert.ToInt16(resposta);
                }
                catch (Exception)
                {
                    num_resposta = 0;
                }
                switch (num_resposta)
                {
                    case 1:
                        string resposta = "";
                        try
                        {
                            while (resposta != "S")
                            {
                                Console.WriteLine("Digite o nome:");
                                string nome = Console.ReadLine();
                                Console.WriteLine("Digite o sobrenome");
                                string sobrenome = (Console.ReadLine());
                                Console.WriteLine("Digite a data de nascimento no formato dd/mm/aaaa");
                                DateTime aniversario = (DateTime.Parse(Console.ReadLine()));
                                Console.WriteLine($"\n{nome} {sobrenome} faz aniversario em {aniversario}");
                                Console.WriteLine("\nEstá correto?\n S \n N");
                                resposta = Console.ReadLine().ToUpper();
                                if (resposta == "S")
                                {
                                    pessoaList.Adicionar(nome, sobrenome, aniversario);
                                    Console.Clear();
                                    Console.WriteLine($"Pessoa adicionada.");
                                }
                                else if (resposta == "N")
                                {
                                    Console.Clear();
                                }
                                else
                                    while (resposta != "S" && resposta != "N")
                                    {
                                        Console.WriteLine("Tente novamente.\nEstá correto?\n S \n N");
                                        resposta = Console.ReadLine().ToUpper();
                                        if (resposta == "S")
                                        {
                                            pessoaList.Adicionar(nome, sobrenome, aniversario);
                                            Console.Clear();
                                            Console.WriteLine($"Pessoa adicionada.");
                                        }
                                        else if (resposta == "N")
                                        {
                                            Console.Clear();
                                        }
                                    }
                            }
                        }
                        catch (Exception)
                        {
                            Console.Write($"Dados inseridos incorretamente. Pessoa não adicionada.");
                        }
                        break;
                    case 2:
                        bool verificador = false;
                        Console.WriteLine(m.pesquisa());
                        try
                        {
                            resposta = Console.ReadLine();

                            pessoaList.Pesquisar(resposta);
                        }
                        catch (Exception)
                        {
                            Console.Clear();
                            Console.WriteLine("\nOpção inválida. Reinicie a procura.");
                        }
                        if (pessoaList.Selecao.Count > 0)
                        {
                            Console.WriteLine("\nEscolha uma opção acima.");
                        }
                        else break;
                        verificador = false;
                        while (!verificador)
                        {
                            try
                            {
                                resposta = Console.ReadLine();
                                int id = Convert.ToInt16(resposta);
                                foreach (Pessoa p in pessoaList.Selecao)
                                {
                                    if (p.Id == id)
                                    {
                                        Console.WriteLine(p.diasParaAniversario());
                                        verificador = true;
                                    }
                                }
                                if (!verificador)
                                {
                                    Console.WriteLine("\nOpção incorreta.\n Escolha uma opção válida.\n");
                                }
                            }
                            catch (Exception)
                            {
                                Console.WriteLine("\nOpção incorreta.\n Escolha uma opção válida.\n");
                            }
                        }
                        pessoaList.Selecao.Clear();
                        break;
                    case 3:
                        Environment.Exit(3);
                        break;
                    default:
                        Console.WriteLine("Opção incorreta.");
                        num_resposta = 0;
                        break;
                }
                Console.WriteLine("\nDigite qualquer tecla para continuar.");
                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}