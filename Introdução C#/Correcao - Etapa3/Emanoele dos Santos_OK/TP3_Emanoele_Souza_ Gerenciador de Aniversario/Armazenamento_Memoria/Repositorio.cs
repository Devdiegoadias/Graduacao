using Pessoa_Model_Biblioteca;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;

namespace Armazenamento_Memoria
{
    public class Repositorio
    {
        protected static List<Pessoa> pessoas = new List<Pessoa>();
        public static void EncontrarPessoa()
        {
            if (pessoas.Count == 0)
            {
                Console.WriteLine("\nA lista esta vazia no momento, adicione pessoas para ver aqui.\n");
            }
            else
            {
                Console.WriteLine("\nAs seguintes pessoas estão armazenadas:\n");
                MostrarPessoaDaListaArmazenada();
                var lerDados = LerDadosConsole("\nDigite o nome ou parte do nome da pessoa que deseja ver:\n");
                ListaDaListaDePessoas(pessoas.Where(e => e.Nome.ToLower().StartsWith(lerDados.ToLower())).ToList());
            }
        }
      
        #region EDITAR()
        public static void Editar()
        {
            if (pessoas.Count == 0)
            {
                Console.WriteLine("\nA lista esta vazia no momento, adicione pessoas para ver aqui.\n");
            }
            else
            {
                Console.WriteLine("\nAs seguintes pessoas estão armazenadas:\n");
                MostrarPessoaDaListaArmazenada();
                var pegarLista = LerDadosConsole("Digite o nome ou parte do nome da pessoa que deseja ver:\n");
                var listaDeNomes = pessoas.Where(e => e.Nome.ToLower().StartsWith(pegarLista.ToLower())).ToList();
                Console.WriteLine("\nFoi encontrado a(s) seguinte(s) pessoa(s) com estas iniciais:");
                foreach (var elemento in listaDeNomes)
                {
                    ImprimirPessoas(elemento);
                }
                //Pega uma pessoa especifica e imprime               
                Console.Write("\nDigite novamente o nome específico acima para manipular suas informações: ");
                var lerDados = Console.ReadLine().ToLowerInvariant();
                var item = listaDeNomes.Cast<Pessoa>().SingleOrDefault(i => i.Nome.ToLowerInvariant() == lerDados.ToLowerInvariant());

                Console.WriteLine($"\nAcessando os dados... {pessoas.IndexOf(item)} ... - {item.Nome} {item.SobreNome} \n");
                var dad = LerDadosConsole("\nPor favor informe quais dados você quer editar:\nDigite [ 1 ] - para editar o nome, [ 2 ] - para editar o sobreNome, [ 3 ] - para a data de nascimento\nOu [ 0 ] - se deseja cancelar a edição:\n");
                switch (dad)
                {
                    case "1":
                        var lerNome = LerDadosConsole("\nDigite as alterações que deseja fazer:\n");
                        if (item.Nome != lerNome)
                        {
                            pessoas.Remove(item);
                            pessoas.Add(new Pessoa()
                            {
                                Nome = lerNome,
                                SobreNome = item.SobreNome,
                                DataAniversario = item.DataAniversario
                            }); Console.WriteLine($"\n*** Alterações salvas com sucesso! ***\n");
                        }
                        else
                        {
                            Console.WriteLine("\nO nome continua o mesmo nenhuma alteração foi feita\n");
                        }
                        break;
                    case "2":
                        var lerSobreNome = LerDadosConsole("\nDigite as alterações que deseja fazer:\n");
                        if (item.SobreNome != lerSobreNome)
                        {
                            pessoas.Remove(item);
                            pessoas.Add(new Pessoa()
                            {
                                Nome = item.Nome,
                                SobreNome = lerSobreNome,
                                DataAniversario = item.DataAniversario
                            }); Console.WriteLine($"\n*** Alterações salvas com sucesso! ***\n");
                        }
                        else
                        {
                            Console.WriteLine("\nO sobrenome continua o mesmo, nenhuma alteração foi feita\n");
                        }
                        break;
                    case "3":
                        var lerData = LerDadosConsole($"\nDigite as alterações que deseja fazer no formato [ dd/MM/yyyy ]:\n");
                        if (DateTime.TryParseExact(lerData, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out _))
                        {
                            pessoas.Remove(item);
                            pessoas.Add(new Pessoa()
                            {
                                Nome = item.Nome,
                                SobreNome = item.SobreNome,
                                DataAniversario = DateTime.ParseExact(lerData, "dd/MM/yyyy", CultureInfo.InvariantCulture)
                            }); Console.WriteLine($"\n*** Alterações salvas com sucesso! ***\n");
                        }
                        else
                        {
                            Console.WriteLine("\nPor favor, Digite a data no formato [ dd/MM/yyy ]\n");
                        }
                        break;
                    case "0":
                        Console.WriteLine("\nAperte qualquer tecla para voltar ao menu principal, nenhuma alteração foi feita...\n");
                        Console.ReadKey();
                        break;
                    default:
                        Console.WriteLine("\npor favor digite uma opção válida\n");
                        break;
                }
            }
        }
        #endregion

        #region Excluir()
        public static void ExclusaoPessoa()
        {
            if(pessoas.Count == 0)
            {
                Console.WriteLine("\nA lista esta vazia no momento, adicione amigos para poder excluir.\n");
            }
            else
            {
                Console.WriteLine("\nAs seguintes pessoas estão armazenadas:\n");
                MostrarPessoaDaListaArmazenada();
                var pegarLista = LerDadosConsole("Digite o nome ou parte do nome da pessoa que deseja ver:\n");
                var listaDeNomes = pessoas.Where(e => e.Nome.ToLower().StartsWith(pegarLista.ToLower())).ToList();
                Console.WriteLine("\nFoi encontrado a(s) seguinte(s) pessoa(s) com estas iniciais:");
                foreach (var elemento in listaDeNomes)
                {
                    ImprimirPessoas(elemento);
                }
                Console.Write("\nDigite novamente o nome específico acima para manipular suas informações: ");
                var lerDados = Console.ReadLine().ToLowerInvariant();
                var item = listaDeNomes.Cast<Pessoa>().SingleOrDefault(i => i.Nome.ToLowerInvariant() == lerDados.ToLowerInvariant());
                pessoas.Remove(item);
                Console.WriteLine($"\n*** Remoção feita com sucesso! ***\n");
            }
        }
        #endregion

        #region Funcoes internas de EncontrarPessoa
        //Lista com as pessoas que possuem nomes semelhantes:
        private static void ListaDaListaDePessoas(IList<Pessoa> listaDoNomeDigitado)
        {
            Console.WriteLine("\nFoi encontrado a(s) seguinte(s) pessoa(s) com estas iniciais:");
            foreach (var elemento in listaDoNomeDigitado)
            {
                ImprimirPessoas(elemento);
            }
            //Pega uma pessoa especifica e imprime
            Console.Write("Digite um dos nomes específicos acima para manipular suas informações: ");
            var lerDados = Console.ReadLine().ToLowerInvariant();
            var item = listaDoNomeDigitado.Cast<Pessoa>().SingleOrDefault(i => i.Nome.ToLowerInvariant() == lerDados.ToLowerInvariant());
            ImprimirPessoas(item);
            //pessoaEspecifica = item;
        }
        public static void MostrarPessoaDaListaArmazenada()
        {
            MostrarListaArmazenada(pessoas);
        }        
        private static void MostrarListaArmazenada(IList<Pessoa> pessoas)
        {
            foreach (var pessoa in pessoas)
            {
                ImprimirPessoas(pessoa);
            }
        }
        #endregion
        private static void ImprimirPessoas(Pessoa pessoa)
        {
            Console.WriteLine($"Nome completo: {pessoa.Nome} {pessoa.SobreNome}, data de Nascimento {pessoa.DataAniversario}");
            Console.WriteLine($"\nPara o aniversario de {pessoa.Nome} Faltam {Pessoa.TempoParaOProximoAniversario(pessoa.DataAniversario)} dias!\n");
        }

        //Ler informações do console:
        public static string LerDadosConsole(string msn)
        {
            Console.WriteLine(msn);
            string caracteresDigitado = null;
            while (string.IsNullOrWhiteSpace(caracteresDigitado))
            {
                caracteresDigitado = Console.ReadLine();
            }
            return caracteresDigitado;
        }
    }
}
