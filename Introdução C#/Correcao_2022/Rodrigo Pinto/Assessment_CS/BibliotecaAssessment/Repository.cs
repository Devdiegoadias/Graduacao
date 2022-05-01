
namespace BibliotecaAssessment
{
    internal class Repository : IRepository
    {
        public Repository()
        {
            this.criarArquivoCasoNaoExista();
        }

        private string nomeArquivo = "lista.txt";
        public Pessoa adicionarPessoa(Pessoa pessoa)
        {
            pessoa.id = this.ultimoId() + 1;

            using (StreamWriter arquivoLista = File.AppendText(nomeArquivo))
            {
                arquivoLista.WriteLine(this.pessoaToString(pessoa));
            }
            return pessoa;
        }
        public List<Pessoa> lerPessoas()
        {
            List<String> lista = File.ReadAllLines(nomeArquivo).ToList();
            List<Pessoa> listaPessoas = new List<Pessoa>();
            foreach (String line in lista)
            {
                var dadosPessoa = line.Split(";");

                Pessoa pessoa = new Pessoa();
                pessoa.id = int.Parse(dadosPessoa[0]);
                pessoa.nome = dadosPessoa[1];
                pessoa.sobrenome = dadosPessoa[2];
                pessoa.dataAniversario = DateTime.Parse(dadosPessoa[3]);
                listaPessoas.Add(pessoa);
            }
            return listaPessoas;
        }

        public void deletarPessoa(int id)
        {
            List<Pessoa> pessoasList = this.lerPessoas();

            pessoasList = pessoasList.Where(pessoa => pessoa.id != id).ToList();

            using (var escrita = new StreamWriter(nomeArquivo))
            {
                foreach (Pessoa pessoa in pessoasList)
                {
                    escrita.WriteLine(this.pessoaToString(pessoa));
                }
            }
        }

        private int ultimoId()
        {
            List<String> lista = File.ReadAllLines(nomeArquivo).ToList();
            if (lista.Count == 0) return 0;

            var ultimaLinha = lista[lista.Count - 1];
            var dadosPessoa = ultimaLinha.Split(";");

            int id = int.Parse(dadosPessoa[0]);
            return id;
        }

        private String pessoaToString(Pessoa pessoa)
        {
            return pessoa.id + ";" + pessoa.nome + ";" + pessoa.sobrenome + ';' + pessoa.dataAniversario + ";";
        }

        public void editarPessoa(Pessoa pessoa)
        {
            List<Pessoa> pessoasList = this.lerPessoas();

            int indexEditado = pessoasList.FindIndex(p => p.id == pessoa.id);

            pessoasList[indexEditado] = pessoa;

            using (var escrita = new StreamWriter(nomeArquivo))
            {
                foreach (Pessoa novaPessoa in pessoasList)
                {
                    escrita.WriteLine(this.pessoaToString(novaPessoa));
                }
            }
        }

        public void criarArquivoCasoNaoExista()
        {
            if (!File.Exists(nomeArquivo))
            {
                using var arquivo = File.Create(nomeArquivo);
            }
        }
    }
}
