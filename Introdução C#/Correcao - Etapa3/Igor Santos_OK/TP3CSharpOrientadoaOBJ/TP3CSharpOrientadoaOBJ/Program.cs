using System;
using System.Collections.Generic;
using Biblioteca.Classes;
namespace TP3CSharpOrientadoaOBJ
{
    class Program
    {
        static void Main(string[] args)
        {

            Rep obj = new Rep();
            Pessoa obj1 = new Pessoa(); 

            while (true)
            {
                Console.Clear();
                Console.WriteLine("Escolha uma opção:\n1 - Adicionar pessoas\n2 - Pesquisar pessoas\n3 - Sair");
                Console.Write("\r\nSelecione uma opção: ");
                switch (Console.ReadLine())
                {
                    case "1":
                        Console.WriteLine("Adicionar pessoas \n");                        
                        obj.inserir();
                        break;

                    case "2":
                        Console.WriteLine("Pesquisar pessoas \n");
                        obj.buscar();
                        break;

                    case "3":                       
                        break;

                    default:
                        break;
                }
            }
        }
           
    }
}
