using System.Globalization;

namespace ClassLibrary
{
    public  class Util
    {
       public  void ListarNumerosFormatados()
        {
            Console.WriteLine("O valor 77777 em vários formatos:");
            Console.WriteLine("c format: {0:c}", 77777);   //R$ 77.777,00
            Console.WriteLine("d9 format: {0:d9}", 77777); //000077777
            Console.WriteLine("d6 format: {0:d6}", 77777); //077777
            Console.WriteLine("f3 format: {0:f3}", 77777); //77777,000
            Console.WriteLine("f2 format: {0:f2}", 77777); //77777,00
            Console.WriteLine("n format: {0:n}", 77777);   //77.777,00
        }

        public void ImprimirUsuario()
        {
            Console.WriteLine("Digite o seu Nome:");
            string nomeUsuario = Console.ReadLine();

            Console.WriteLine("Digite o seu Sobrenome:");
            string sobreNomeUsuario = Console.ReadLine();

            //Double salarioUsuario = double.Parse(Console.ReadLine());
            Double salarioUsuario = 999.98;

            var t = salarioUsuario.GetType();

            Console.WriteLine("o  tipo da variavel salarioUsuario é: " + t.Name);

            var salarioEmDolar = salarioUsuario.ToString("C", new CultureInfo("en-US", false));
            var salarioEmReal = salarioUsuario.ToString("C", CultureInfo.CurrentCulture);

            Console.WriteLine("Seu salário em formato americano é:" + salarioEmDolar);

            Console.WriteLine("Seu salário em formato brasileiro é:" + salarioEmReal);
        }

        public void OperadoresLogicos()
        {
            Console.WriteLine("============ Operadores Lógicos ============");

            bool t = true;
            bool f = false;
            Console.Clear();

            Console.WriteLine($"{t} && {t} = {t && t}"); //True && True = True
            Console.WriteLine($"{t} && {f} = {t && f}"); //True && False = False
            Console.WriteLine($"{f} && {f} = {f && f}"); //False && False = False

            Console.WriteLine($"{t} || {t} = {t || t}"); //True || True = True
            Console.WriteLine($"{t} || {f} = {t || f}"); //True || False = True
            Console.WriteLine($"{f} || {f} = {f || f}"); //False || False = False

            Console.WriteLine($"!{t} = {!t}"); //!True = False
            Console.WriteLine($"!{f} = {!f}"); //!False = True

            int num1 = 1;
            int num2 = 2;

            if (num1 == 1 && num2 == 2)
            {
                Console.WriteLine("num1 e num2 ok");
            }

            if (num1 == 1 || num2 == 2)
            {
                Console.WriteLine("num1 e num2 ok");
            }

            if (!(num1 == 1 || num2 == 2))
            {
                Console.WriteLine("num1 e num2 ok");
            }

            if (!false)
            {
                Console.WriteLine("num1 e num2 ok");
            }
        }

    }
}