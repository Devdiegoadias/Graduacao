using System;

namespace $safeprojectname$
{
    class Program
    {
        static void Main(string[] args)
        {
            List<pessoa> lista = new List<pessoa>();
            Console.WriteLine("Insira seu nome: ");
            string nome = Console.ReadLine();

            Console.WriteLine("Insira sua data de aniversario: ");
            int ano = Convert.ToInt32(Console.ReadLine());

            pessoa novo = new pessoa(nome, ano);
            lista.Add(novo);

            Console.Write(lista);
        }
    }
}
