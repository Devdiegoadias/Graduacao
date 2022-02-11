using System.Globalization;
using ClassLibrary;

namespace etapa2
{ 
    public class Pessoa
    {
        public string nome;
        public DateTime data;
    }
    class Program
    {
        static void Main(string[] arg)
        {
            Console.WriteLine("***** MENU *****");
            Console.Title = "Aplicação ETAPA 2.2";
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.BackgroundColor = ConsoleColor.Blue;

            Console.WriteLine("**************************");
            Console.WriteLine("***** Welcome Etapa 2*****");
            Console.WriteLine("**************************");

            Console.BackgroundColor = ConsoleColor.Black;

            // ImprimirUsuario();            
            // ListarNumerosFormatados();
            
            Pessoa pessoa = new Pessoa();
            
            if(pessoa != null)
            {
                Util util = new Util();
                util.ImprimirUsuario();
                util = null;
            }
            pessoa = null;

            if (pessoa != null)
            {
                Util util = new Util();
                util.ImprimirUsuario();
            }

            Console.ReadKey();
        }

       
    }

}
