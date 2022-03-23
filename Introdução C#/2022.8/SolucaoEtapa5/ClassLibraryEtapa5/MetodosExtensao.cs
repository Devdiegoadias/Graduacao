using System.Text.RegularExpressions;


namespace ClassLibraryEtapa5
{
    public static class blablabla
    {
        public static bool EmailValido(this string email)
        {
            bool bVariavel = Regex.IsMatch(email, @"^[A-Za-z0-9](([_\.\-]?[a-zA-Z0-9]+)*)@([A-Za-z0-9]+)(([\.\-]?[a-zA-Z0-9]+)*)\.([A-Za-z]{2,})$");
            return bVariavel;
        }

        public static int MultiplicaPorDois(this int numero)
        {
            return numero * 2;
        }

        public static float MultiplicaPorDois(this float numero)
        {
            return numero * 2;
        }

        public static object TesteObject(this object obj)
        {
            if (obj is int)
            {
                return int.Parse(obj.ToString()) * 2;
            }

            if (obj is float)
            {
                return float.Parse(obj.ToString()) * 3;
            }

            return null;
        }

        public static string ToString(this int num)
        {
            return "Blablabala";
        }


        public static int PrecoBlackFriday(this CalculaPreco p, int preco, int quantidade)
        {
            return p.CalculoFinal(preco, quantidade) - 200;
        }


    }
}
