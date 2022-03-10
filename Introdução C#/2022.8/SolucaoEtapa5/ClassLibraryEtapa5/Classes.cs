namespace ClassLibraryEtapa5
{
    public abstract class Pessoa
    {
         string _nome;
         string _cpf;
         Generos _genero;
         
        
        public Pessoa( string nome, string cpf, Generos genero) 
        {
            _nome = nome;
            _cpf = cpf;
            _genero = genero;
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
       

        public Colaborador(int matricula, string nome, string cpf, bool especial, float salario, Generos genero):base(nome,cpf,genero)
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
        public Cliente(string nome, string cpf, decimal valorCompra, Generos genero):base(nome,cpf, genero)
        {            
            _valorCompra = valorCompra;
        }

        public override void Escrever()
        {
            Console.WriteLine("EU SOU UM CLIENTE");
        }
    }
}