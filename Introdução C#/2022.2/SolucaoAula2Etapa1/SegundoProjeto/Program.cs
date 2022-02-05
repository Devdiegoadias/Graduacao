using System;

namespace Stop
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string NomeAlunoSegundoProjeto;
            DateTime now = GetCurrentDate();
            Console.WriteLine($"Today's date is {now}");
            

            NomeAlunoSegundoProjeto = "Teles";
            Console.WriteLine($"O Nome é {NomeAlunoSegundoProjeto}");
        }



        internal static DateTime GetCurrentDate()
        {
            return DateTime.Now.Date;
        }
    }
}
