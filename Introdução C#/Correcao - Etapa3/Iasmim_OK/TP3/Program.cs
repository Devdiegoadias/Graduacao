using ConsoleApp1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace TP3
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
            Console.ReadKey();
        }

        public static void Menu()
        {
            bool menu = true;
            string optionMenu;
            do
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("\nGERENCIADOR DE ANIVERSÁRIOS\n"
                    + "\n1 - ADICIONAR USUÁRIO"
                    + "\n2 - PESQUISAR USUÁRIO"
                    + "\n3 - SAIR\n"
                    + "\nESCOLHA UMA DAS OPÇÕES ACIMA:");
                Console.ResetColor();

                optionMenu = Console.ReadLine();
                switch (optionMenu)
                {
                    case "1":
                        AddUser();
                        break;
                    case "2":
                        SearchUser();
                        break;
                    case "3":
                        menu = false;
                        Console.WriteLine("APERTE QUALQUE TECLA PARA SAIR");
                        break;
                    default:
                        break;
                }
            } while (menu);
        }

        public static void AddUser()
        {
            string name, surname;
            DateTime birthDate;

            Console.WriteLine("DIGITE SEU NOME:");
            name = Console.ReadLine().ToUpper();

            Console.WriteLine("DIGITE SEU SOBRENOME:");
            surname = Console.ReadLine().ToUpper();

            do
                Console.WriteLine("DIGITE SUA DATA DE NASCIMENTO: (dd/mm/yy)");
            while (!DateTime.TryParse(Console.ReadLine(), out birthDate));
            Console.WriteLine($"\nNAME:{name} {surname}"+
                $"\nDATA DE NASCIMENTO:{birthDate.ToString("d")}" +
                $"\nSEUS DADOS ESTÃO CORRETOS? (S/N)");
            string answer = Console.ReadLine().ToUpper();

            if (answer == "S")
            {
                People people = new People()
                {
                    Name = name,
                    Surname = surname,
                    BirthDate = birthDate
                };
                PeopleLibrary.RegisterUser(people);
                Console.WriteLine("\nUSUÁRIO CADASTRADO COM SUCESSO!");
            }
            else
                Console.WriteLine("\nUSUÁRIO NÃO CADASTRADO" + "\nTENTE NOVAMENTE");
        }

        public static void SearchUser()
        {
            List<People> users;
            Console.WriteLine("DIGITE O NOME DO USUÁRIO QUE DESEJA BUSCAR:");
            string name = Console.ReadLine().ToUpper();
            int index = 0;
            int choice;
            users = PeopleLibrary.SearchUsers(name);

            if (!users.Any())
                Console.WriteLine("USUÁRIO NÃO ENCONTRADO");
            else
            {
                foreach (var people in users)
                {
                    Console.WriteLine($"{index} - {people.Name} {people.Surname}");
                    index++;
                }
                do
                    Console.WriteLine("ESCOLHA UM USUÁRIO:");
                while (!int.TryParse(Console.ReadLine(), out choice));
                if (choice < users.Count)
                    Console.WriteLine(PeopleLibrary.DisplayRegisteredData(users[choice]));
                else
                    Console.WriteLine("OPÇÃO INVÁLIDA");
            }
        }
    }
}
