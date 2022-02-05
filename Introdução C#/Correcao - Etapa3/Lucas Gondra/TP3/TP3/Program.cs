using PplRepo;
using System;
using System.Collections;
using System.Collections.Generic;

namespace TP3
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Repositorio r = new Repositorio();

            bool stop = false;
            while (!stop) 
            {
                Console.WriteLine(" Gerenciador de aniversarios: \n" +
                " 1 - Pesquisar pessoas \n" +
                " 2 - Adicionar nova pessoa \n" +
                " 3 - Sair");
                var menu = Console.ReadLine();
                switch (menu)
                {
                    case "1":
                        r.Search();
                        break;
                    case "2":
                        r.Addppl();
                        break;
                    default:
                        stop = true;
                        break;
                }
            }
        }
        
        
    }
}
