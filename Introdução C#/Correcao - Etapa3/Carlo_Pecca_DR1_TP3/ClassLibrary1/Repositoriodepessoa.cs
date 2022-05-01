namespace ClassLibrary1
{
    public class Repositoriodepessoa
    {
        private static List<Pessoa> _pessoas = new();
        public List<Pessoa> selecao = new();
        int id = 0;

        public List<Pessoa> Pessoas { get { return _pessoas; } }

        public List<Pessoa> Selecao { get { return selecao; } set { } }
        public void Adicionar(string nome, string sobrenome, DateTime aniversario)
        {
            id = _pessoas.Count + 1;
            Pessoa p = new(id, nome, sobrenome, aniversario);
            _pessoas.Add(p);
        }
        public void Pesquisar(string pesquisa)
        {
            bool confirmacao = false;
            foreach (Pessoa p in _pessoas)
            { 
                bool verificacao = p.Nome.Contains(pesquisa, StringComparison.CurrentCultureIgnoreCase);
                if (verificacao)
                {
                    confirmacao = true;
                    Console.Write( $"{p.Id} - {p.Nome} {p.Sobrenome}\n");
                    selecao.Add(p);
                }
            }
            if (!confirmacao)
            {
                foreach (Pessoa p in _pessoas)
                {
                    bool verificacao = p.Sobrenome.Contains(pesquisa, StringComparison.CurrentCultureIgnoreCase);
                    if (verificacao)
                    {
                        confirmacao = true;
                        Console.Write($"{p.Id} - {p.Nome} {p.Sobrenome}\n");
                        selecao.Add(p);
                    }
                }
            }
            if (!confirmacao)
            {
                Console.WriteLine("Nome não encontrado");
            }
        }
    }
}

