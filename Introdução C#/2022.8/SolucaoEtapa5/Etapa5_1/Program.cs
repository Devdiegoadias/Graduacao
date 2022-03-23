using ClassLibraryEtapa5;
class Programa
{
    public static void Main(string[] args)
    {
        try
        {
            string emailColaborador = string.Empty;

            emailColaborador = "Carlo.Pecca@exercito.com.br";

            emailColaborador.EmailValido();

            int num = 5;

            int num2 = 10;
            float num3 = 30;

            num.MultiplicaPorDois();
            num2.MultiplicaPorDois();

            var retorno = num.TesteObject();

            retorno = num3.TesteObject();

            retorno = emailColaborador.TesteObject();

            CalculaPreco preco = new CalculaPreco();

            Pai varPai = new Pai();

            varPai._cpf = 100000;

            Console.WriteLine("Preco comum:" + preco.CalculoFinal(10, 1000));
            Console.WriteLine("Preco blackfriday:" + preco.PrecoBlackFriday(10, 1000));
            
            varPai._cpf = 4242340;


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
            PagamentoBoleto pagtoboleto = new PagamentoBoleto("1111111", 10000);

            PagamentoCartao pagtocartao = new PagamentoCartao("Carlos", Bandeiras.MasterCard, 100000);

            pagtoboleto.EscreverValorPagamento();

            pagtocartao.EscreverValorPagamento();


            ICalcularPagamento ipagto = pagtoboleto;

            ipagto.CalcularPagamento();

            ipagto = pagtocartao;

            ipagto.CalcularPagamento();


            Pagamento pagto = pagtoboleto;
            pagto = pagtocartao;

            PagamentoBoleto pagtoboleto2 = new PagamentoBoleto("1111111", 10000);

            PagamentoCartao pagtocartao2 = new PagamentoCartao("Carlos", Bandeiras.MasterCard, 100000);

            var lstpagamento = new List<Pagamento>();

            lstpagamento.Add(pagtocartao);
            lstpagamento.Add(pagtoboleto);
            lstpagamento.Add(pagtocartao2);
            lstpagamento.Add(pagtoboleto2);

            foreach (Pagamento p in lstpagamento)
            {
                p.ValorPagamento = 10;
                p.EscreverValorPagamento();
            }

            foreach (ICalcularPagamento i in lstpagamento)
            {

                Console.WriteLine(i.CalcularPagamento());
            }


            var colaborador1 = new Colaborador(444, "Carlo", "08755598834", true, 50000, Generos.Masculino);
            var colaborador2 = new Colaborador(333, "Teles", "08755598834", true, 30000, Generos.Masculino);
            var colaborador3 = new Colaborador(222, "Lucas", "08755598834", true, 40000, Generos.Masculino);
            var colaborador4 = new Colaborador(111, "Rodrigo", "08755598834", true, 20000, Generos.Masculino);

            Console.WriteLine(colaborador4.ToString());

            var lstColaborador = new List<Colaborador>();

            lstColaborador.Add(colaborador1);
            lstColaborador.Add(colaborador2);
            lstColaborador.Add(colaborador3);
            lstColaborador.Add(colaborador4);

            Console.WriteLine("maria".CompareTo("antonia"));
            Console.WriteLine("maria".CompareTo("neide"));
            Console.WriteLine("maria".CompareTo("maria"));


            lstColaborador.Sort();

            foreach (var x in lstColaborador)
            {
                Console.WriteLine(x.ToString());
            }

            Console.WriteLine("");
            Console.WriteLine("");

            var lst = lstColaborador.OrderBy(x => x._matricula);

            foreach (var x in lst)
            {
                Console.WriteLine(x.ToString());
            }

            Console.ReadKey();
        }
        catch (InfnetNegocioException e)
        {

        }
        catch (ArgumentException e)
        {
            Console.WriteLine("Argumento inválido:" + e.Message + e.InnerException?.Message + e.StackTrace);
        }
        catch (InvalidOperationException e)
        {
            Console.WriteLine(e.Message);
        }
        catch (Exception ex)
        {

        }
    }
}