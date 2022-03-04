namespace ClassLibraryEtapa5
{
    public abstract class Pessoa
    {
         string _nome;
         string _cpf;
         
        
        public Pessoa( string nome, string cpf) 
        {
            _nome = nome;
            _cpf = cpf;
        }

        public virtual void Escrever()
        {
            Console.WriteLine("Eu sou uma Pessoa");
        }
    }

    public class Colaborador : Pessoa
    {
        public int _matricula;
        private readonly bool _colaboradorEspecial;
        public static int bonus;
        public float _salario;
       

        public Colaborador(int matricula, string nome, string cpf, bool especial, float salario):base(nome,cpf)
        {
            _matricula = matricula;            
            _colaboradorEspecial = especial;
            _salario = salario;
        }

        public float calculaPLR()
        {
            return _salario * bonus ;
        }       
       
        public override void Escrever()
        {
            Console.WriteLine("EU SOU UM COLABORADOR !");
        }        
       
    }

    public class Cliente : Pessoa
    {
        decimal _valorCompra;
        public Cliente(string nome, string cpf, decimal valorCompra):base(nome,cpf)
        {            
            _valorCompra = valorCompra;
        }

        public override void Escrever()
        {
            Console.WriteLine("EU SOU UM CLIENTE");
        }
    }
}