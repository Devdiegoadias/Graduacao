using System;
using aulacsharp9do11.Classes;

namespace aulacsharp9do11
{
   
    class Program
    {
        static void Main(string[] args)
        {
            Celular c1 = new Celular("celular1", 1000,Celular.Tensao.v110, Celular.Marcas.Apple);


            Console.Read();
        }
    }
}
