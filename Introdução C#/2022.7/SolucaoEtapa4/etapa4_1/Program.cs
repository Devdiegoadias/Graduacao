using  ClassLibraryEtapa4;
class Programa
{
    public static void Main(string[] args)
    {
        try
        {
            var colaborador1 = new Colaborador(111, "Carlo", "08755598834",true);
            Pessoa p1 = colaborador1;

            colaborador1.Escrever();
            
            
            Cliente cliente1 = new Cliente("Teles", "08722533347", 10000);
            Pessoa p2 = cliente1;

            cliente1.Escrever();



        }
        catch (InfnetNegocioException e)
        {

        }
        catch (Exception ex)
        {

        }
    }
}