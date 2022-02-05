using System;
using System.Collections.Generic;
using System.Text;

namespace Biblioteca.Classes
{
    public class Rep : Pessoa
    {
        private List<Pessoa> myList = new List<Pessoa>();
        //List<List<object>> myList = new List<List<object>>();

        public void inserir()
        {
            while (true)
            {                
                Console.WriteLine("Informe o seu nome:");
                Nome = Console.ReadLine();

                Console.WriteLine("\nInforme o seu sobrenome:");
                Sobrenome = Console.ReadLine();

                Console.WriteLine("\nInforme a sua data de nascimento:");
                Nascimento = Convert.ToDateTime(Console.ReadLine());

                Console.WriteLine($"Os dados abaixo estão corretos?\nNome: {Nome}\nSobrenome: {Sobrenome}\nData de nascimento: {Nascimento}\nDias restantes para o próximo aniversário: {tempo()}");
                Console.WriteLine("1 - Sim\n2 - Não");
                int caso = Convert.ToInt32(Console.ReadLine());

                Pessoa pessoa = new Pessoa()
                {
                    Nome = Nome,
                    Sobrenome = Sobrenome,
                    Nascimento = Nascimento
                };

                if (caso == 1)
                {
                    Console.WriteLine("Caso 1 escolhido");
                    myList.Add(pessoa);
                    Console.ReadLine();
                    break;
                }
                else
                {
                    Console.WriteLine("Caso 2 escolhido");
                    //faça de novo
                }
            }

        }

        public void buscar()
        {
            Console.WriteLine("Digite o nome da pessoa: ");
            string pesquisar = Console.ReadLine();
            foreach (Pessoa item in myList)
            {

                if (item.Nome.Contains(pesquisar))
                {
                    Console.WriteLine(string.Format("0 - Esses são os dados encontrados: ({0}).", string.Join(", ", item.Nome, item.Sobrenome, item.Nascimento, tempo() + " dias restantes")));

                }
                else
                {
                    Console.WriteLine("0 - ");
                }
               

            }
                Console.ReadLine();
        }
    }
}
