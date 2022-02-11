using System;
using System.Globalization;

namespace BasicConsoleIO
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Basic Console I/O *****");
            // Set up Console UI (CUI)
            Console.Title = "My Rocking App";
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.WriteLine("*************************************");
            Console.WriteLine("***** Welcome to My Rocking App *****");
            Console.WriteLine("*************************************");
            Console.BackgroundColor = ConsoleColor.Black;

            // Wait for Enter key to be pressed.
            Console.ReadLine();

            GetUserData();      

            Console.ReadLine();


            double preco = 14.99;
            var now = DateTime.Now;

            var precoFormatadoDolar = preco.ToString("C", new CultureInfo("en-US", false));
            var precoFormatadoCulturaLocal = preco.ToString("C", CultureInfo.CurrentCulture);

            Console.WriteLine("----- Formatação de moeda -----");

            Console.WriteLine($"Preço (em dólares): {precoFormatadoDolar}");
            Console.WriteLine($"Preço (em  moeda local): {precoFormatadoCulturaLocal}");

            Console.WriteLine("----- Formatação de data -----");

            Console.WriteLine("----- Usando string.Format -----");
            var dataStringFormat = string.Format("Data longa: {0:D}, Data Curta: {1:d}, Moeda: {2:C}\n", now, now, preco);
            Console.WriteLine(dataStringFormat);

            Console.WriteLine("----- Usando sobrecargas de ToString -----");

            var dataFormatadaLonga = now.ToString("D"); // equivalente a now.ToLongDateString();
            var dataFormatadaCurta = now.ToString("d"); // equivalente a now.ToShortDateString();
            var dataFormatadaPersonalizada = now.ToString("dd-MM-yyyy");

            Console.WriteLine($"Data em formato longo: {dataFormatadaLonga}");
            Console.WriteLine($"Data em formato curto: {dataFormatadaCurta}");
            Console.WriteLine($"Data em formato dd-MM-yyyy: {dataFormatadaPersonalizada}\n");

            Console.WriteLine("----- Usando interpolação de string -----");

            Console.WriteLine($"Data longa: {now:D}, Data curta: {now:d}, Moeda: {preco:C}");

            Console.ReadLine();


        }
        #region Get user data
        static void GetUserData()
        {
            // Get name and age.
            Console.Write("Please enter your name: ");
            string userName = Console.ReadLine();
            Console.Write("Please enter your age: ");
            string userAge = Console.ReadLine();

            // Change echo color, just for fun.
            ConsoleColor prevColor = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Yellow;
            // Echo to the console.
            Console.WriteLine("Hello {0}! You are {1} years old.",
                userName, userAge);

            // Restore previous color.
            Console.ForegroundColor = prevColor;

            LogicalOperatorsExample();
            FormatNumericalData();
        }
        #endregion

        static void FormatNumericalData()
        {
            Console.WriteLine("The value 99999 in various formats:");
            Console.WriteLine("c format: {0:c}", 99999);
            Console.WriteLine("d6 format: {0:d6}", 99999);
            Console.WriteLine("d9 format: {0:d9}", 99999);
            Console.WriteLine("f3 format: {0:f3}", 99999);
            Console.WriteLine("f7 format: {0:f7}", 99999);
            Console.WriteLine("n format: {0:n}", 99999);
        }

            static void LogicalOperatorsExample()
        {
            Console.WriteLine("================ Logical Operators ===============/n");
            bool t = true;
            bool f = false;
            Console.WriteLine($"{t.ToString()} && {t.ToString()} = {t && t}"); //true
            Console.WriteLine($"{t.ToString()} && {f.ToString()} = {t && f}"); //false
            Console.WriteLine($"{t.ToString()} || {t.ToString()} = {t || t}"); //true
            Console.WriteLine($"{t.ToString()} || {f.ToString()} = {t || f}"); //true
            Console.WriteLine($"{f.ToString()} || {f.ToString()} = {f || f}"); //false
            Console.WriteLine($"!{t.ToString()} = {!t}"); //false
            Console.WriteLine($"!{f.ToString()} = {!f}"); //true
        }
    }
}