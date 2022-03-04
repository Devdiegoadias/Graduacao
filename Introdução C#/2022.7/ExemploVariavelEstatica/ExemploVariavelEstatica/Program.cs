namespace ExVariavelEstatica
{
    class VariavelEstatica
    {
        public static int numero; //variável estática

        public void contagem()
        {
            numero++;
        }

        public int getNumero()
        {
            return numero;
        }

        public int soma(int a, int b) // método estático
        {
            return a + b;
        }
    }

    static class Utilitario
    {
        public static bool ValidarCPF()
        {
            //codigo fonte....
            return true;
        }
        public static bool ValidarCNPJ()
        {
            //codigo fonte....
            return true;
        }

        public static bool VerificaCEP() // método estático
        {
            //codigo fonte....
            return true;
        }
    }


    class ExemploVariavelEstatica
    {
        static void Main(string[] args)
        {
            Utilitario.VerificaCEP();

            //Utilitario u1 = new Utilitario(); -> Dá erro pq é uma 'static class'

            //Math m = new Math();  -> Dá erro pq é uma 'static class'

            VariavelEstatica v1 = new VariavelEstatica();
            VariavelEstatica v2 = new VariavelEstatica();

            v1.soma(2, 3);

            v1.contagem();
            v1.contagem();
            v1.contagem();
            v1.contagem();
            v1.contagem();

            v2.contagem();
            v2.contagem();
            v2.contagem();

            VariavelEstatica.numero = 999;

            v1.contagem();
            v1.contagem();
            v1.contagem();
            v1.contagem();
            v1.contagem();

            v2.contagem();
            v2.contagem();
            v2.contagem();

            Console.WriteLine("Valor de numero para v1:" + v1.getNumero());
            Console.WriteLine("Valor de numero para v2:" + v2.getNumero());
        }
    }
}