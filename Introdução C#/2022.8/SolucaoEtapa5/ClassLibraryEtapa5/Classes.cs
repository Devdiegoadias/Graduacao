namespace ClassLibraryEtapa5
{
    public abstract class Pessoa
    {
         protected string _nome;
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

    public class Colaborador : Pessoa,IComparable<Colaborador>
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

        public string Nome{get{return base._nome;}set{}}

        public float calculaPLR()
        {
            return _salario * bonus ;
        }       
       
        public override void Escrever()
        {
            Console.WriteLine("EU SOU UM COLABORADOR !");
        }

        public int CompareTo(object? obj)
        {
            if(!(obj is Colaborador))
            {
                throw new ArgumentException("Argumento inválido");
            }

            Colaborador colaboradorRecebidoParametro = (Colaborador) obj;

            return _matricula.CompareTo(colaboradorRecebidoParametro._matricula);
        }

        public int CompareTo(Colaborador? other)
        {           
            if (other == null)
                return -1;
            return _salario.CompareTo(other._salario);            
        }

        public override string ToString()
        {            
            return $"Matricula:{_matricula}, Nome:{base._nome}, Salario:{_salario}";
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