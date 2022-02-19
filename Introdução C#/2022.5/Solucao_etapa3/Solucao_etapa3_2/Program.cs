using Solucao_etapa3;


class etapa3_2
{
    public class Colaborador
    {
        private  int _matricula { get; set; }
        private string _nome { get; set; }
        private string _cpf { get; set; }
        private decimal Salario { get; set; }
        private decimal Bonus { get; set; }

        public Colaborador()
        {

        }

        public Colaborador(int matricula, string nome, string cpf, decimal salario)
        {
            _matricula = matricula;
            _nome = nome;
            _cpf = cpf;
            Salario = salario;
        }

        //Getters e setters
        public int Matricula
        {
            get
            {
                return _matricula;
            }

            set
            {
                _matricula = value;
            }
        }

        public string Nome
        {
            get
            {
                return _nome;
            }

            set
            {
                if (value.Trim() == String.Empty)
                {
                    
                    throw new Exception("NOME NAO PODE SER EM BRANCO");
                }

                if (value.Trim().ToUpper() == "CLARA")
                {
                    throw new BusinessException("CLARA NÂO PODE ENTRAR");
                }

                _nome = value.ToUpper();
            }
        }

        public string Cpf 
        { 
            get
            {
                return _cpf;
            }
            set
            {

            }
        }

        public void CalculaBonus()
        {
            Bonus = Salario *= 2;
        }

        public void CalculaDescontoINSS()
        {
            Bonus = Salario - 2;
        }

    }

    static void Main()
    {
        try
        {
            Colaborador c1 = new Colaborador();
            Colaborador c2 = new Colaborador(0, "Carlo", "77777777",7000);

            c1.Matricula = 777;
            Console.WriteLine($"Matricula: {c1.Matricula}");

            c1.Nome = "clara      ";
            Console.WriteLine($"Nome:{c1.Nome}");
        }
        catch (BusinessException e)
        {
            Console.WriteLine($"Erro Regra de negocio: {e.Message}");
        }
        catch (IndexOutOfRangeException e)
        {
            Console.WriteLine($"Erro Regra de negocio: {e.Message}");
        }
        catch (InvalidDataException e)
        {
            Console.WriteLine($"Erro Regra de negocio: {e.Message}");
        }        
        catch (Exception e)
        {
            Console.WriteLine($"Erro: {e.Message}");
        }

        
        string str = string.Empty;      
        
        str = @"C:\Users\dtdias\";

        Console.WriteLine(str);

        char[] letras = { 'A', 'B', 'C', 'D', 'E' };

        string letrasStr = new string(letras);

        Console.WriteLine(letrasStr);

        for(int i=0; i<=4;i++)
        {
            Console.WriteLine(letras[i]);
        }

        try
        {
            System.Collections.ArrayList lstColaboradores = new System.Collections.ArrayList();

            Colaborador c3 = new Colaborador(1, "Carlo", "1111",8);
            Colaborador c4 = new Colaborador(2, "Teles", "2222",9);
            Colaborador c5 = new Colaborador(3, "Lucas", "3333",10);
            Colaborador c6 = new Colaborador(4, "Rodrigo", "44444",11);
            Colaborador c7 = new Colaborador(5, "Roger", "5555",11);

            lstColaboradores.Add(c3);
            lstColaboradores.Add(c4);
            lstColaboradores.Add(c5);
            lstColaboradores.Add(c6);
            lstColaboradores.Add(c7);
            lstColaboradores.Add("STRING");

            foreach (Colaborador v in lstColaboradores)
            {                
                Console.WriteLine(v.Matricula);
                Console.WriteLine(v.Nome);
                Console.WriteLine(v.Cpf);
                v.CalculaBonus();
                v.CalculaDescontoINSS();
            }
        }
        catch(InvalidCastException e)
        {
            Console.WriteLine("Erro no cast - Tipo invalido " + e.Message);
        }
    }
}

