using Solucao_etapa3;

class etapa3
{
    public class Pessoa
    {
        public string Nome { get; set; }
        public string Profissao { get; set; }


        public Pessoa(string nome, string profissao)
        {
            Nome = nome;
            Profissao = profissao;
        }

        public void DizerOi()
        {
            Console.WriteLine($"Olá ! Me chamo {Nome} e sou {Profissao}");
        }
    }

    static void Main()
    {
        ///SOBRE REFERÊNCIA        
        Pessoa p1 = new Pessoa("Clara", "Medica");
        //p1.DizerOi();

        Pessoa p2 = p1;
        p2.Nome = "João";
        //p1.DizerOi();

        Pessoa p3 = new Pessoa("Mario", "Programador");
        p3.Nome = "Tadeu";
        //p3.DizerOi();

        Pessoa p4 = p3;
        p3.Profissao = "Engenheiro";
        //p4.DizerOi();

        p4 = p1;
        //p4.DizerOi();
        //p1.DizerOi();


        //VALOR
        int i = 7;
        int j = i;
        j = 8;
        // Console.WriteLine("I=" + i + " " + "J=" + j);


        int k = 123;
        object o = k; //Boxing

        try
        {
            int l = (int)o;

            l = l * 10;
            
            if (l > 100)
                throw new BusinessException("RN1: Valor da Variável l >100");
        }
        catch (BusinessException e)
        {
            Console.WriteLine(e.Message);
        }
        catch (Exception e)
        {
            Console.WriteLine($"Houve erro: {e.Message + e.InnerException } no trecho {e.StackTrace }"  );
            
        }       

    }
}