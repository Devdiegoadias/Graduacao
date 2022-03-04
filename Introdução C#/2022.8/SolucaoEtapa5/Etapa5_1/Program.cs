using  ClassLibraryEtapa5;
class Programa
{
    public static void Main(string[] args)
    {
        try
        {
            Colaborador.bonus = 2;

            var colaborador1 = new Colaborador(111, "Carlo", "08755598834",true,10000);
            var colaborador2 = new Colaborador(222, "Teles", "08755598834", true, 10000);
            var colaborador3 = new Colaborador(333, "Lucas", "08755598834", true, 10000);
            var colaborador4 = new Colaborador(444, "Rodrigo", "08755598834", true, 10000);

            colaborador1.calculaPLR();
            colaborador2.calculaPLR();
            colaborador3.calculaPLR();
            colaborador4.calculaPLR();

            //Alterando o Bonus
            Colaborador.bonus = 10;
            
            colaborador1.calculaPLR();
            colaborador2.calculaPLR();
            colaborador3.calculaPLR();
            colaborador4.calculaPLR();

            Pessoa p1 = colaborador1;
            

            colaborador1.Escrever();
            p1.Escrever();
            
            
            Cliente cliente1 = new Cliente("Teles", "08722533347", 10000);
            Pessoa p2 = cliente1;

            cliente1.Escrever();
            p2.Escrever(); 

        }
        catch (InfnetNegocioException e)
        {

        }
        catch (Exception ex)
        {

        }
    }
}