using ClassLibraryEtapa5;
class Programa
{
    public static void Main(string[] args)
    {
        try
        {
            /*
             Colaborador.bonus = 2;

             var colaborador1 = new Colaborador(111, "Carlo", "08755598834",true,10000,Generos.Masculino);
             var colaborador2 = new Colaborador(222, "Teles", "08755598834", true, 10000, Generos.Masculino);
             var colaborador3 = new Colaborador(333, "Lucas", "08755598834", true, 10000, Generos.Masculino);
             var colaborador4 = new Colaborador(444, "Rodrigo", "08755598834", true, 10000, Generos.Masculino);

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


             Cliente cliente1 = new Cliente("Teles", "08722533347", 10000, Generos.Masculino);
             Pessoa p2 = cliente1;

             cliente1.Escrever();
             p2.Escrever();
            */

            PagamentoBoleto pagtoboleto = new PagamentoBoleto("1111111",10000);

            PagamentoCartao pagtocartao = new PagamentoCartao("Carlos", Bandeiras.MasterCard,100000);

            pagtoboleto.EscreverValorPagamento();

            pagtocartao.EscreverValorPagamento();

            /*
            IPagamento ipagto = pagtoboleto;

            ipagto.EscreverValorPagamento();

            ipagto = pagtocartao;

            ipagto.EscreverValorPagamento();
            */

            Pagamento pagto = pagtoboleto;
            pagto = pagtocartao;

            PagamentoBoleto pagtoboleto2 = new PagamentoBoleto("1111111", 10000);

            PagamentoCartao pagtocartao2 = new PagamentoCartao("Carlos", Bandeiras.MasterCard, 100000);

            var lstpagamento = new List<Pagamento>();

            lstpagamento.Add(pagtocartao);
            lstpagamento.Add(pagtoboleto);
            lstpagamento.Add(pagtocartao2);
            lstpagamento.Add(pagtoboleto2);

            foreach(Pagamento p in lstpagamento)
            {
                p.ValorPagamento = 10;
                p.EscreverValorPagamento();
            }

            foreach(ICalcularPagamento i in lstpagamento)
            {
                
               Console.WriteLine( i.CalcularPagamento());
            }

        }
        catch (InfnetNegocioException e)
        {

        }
        catch (Exception ex)
        {

        }
    }
}