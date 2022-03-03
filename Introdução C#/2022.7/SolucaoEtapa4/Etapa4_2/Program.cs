
class Programa
{
    public static void Main(string[] args)
    {
        Humano h = new Humano();
        h.mensagem();

        Colaborador c = new Colaborador();
        c.mensagem();

        h = c;

        h.mensagem();


    }
}
