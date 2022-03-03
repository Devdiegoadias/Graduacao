namespace ClassLibraryEtapa4
{
    public abstract class Pessoa
    {
        public string _nome;
        protected string _cpf;

        public Pessoa( string nome, string cpf) 
        {
            _nome = nome;
            _cpf = cpf;
        }

        public abstract void Escrever();
    }

    public class Colaborador : Pessoa
    {
        public int _matricula;
        private readonly bool _colaboradorEspecial;

        public Colaborador(int matricula, string nome, string cpf, bool especial):base(nome,cpf)
        {
            _matricula = matricula;            
            _colaboradorEspecial = especial;
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