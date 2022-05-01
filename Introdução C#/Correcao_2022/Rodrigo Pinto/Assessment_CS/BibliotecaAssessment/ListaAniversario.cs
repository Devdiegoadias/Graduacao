
namespace BibliotecaAssessment
{
    public class ListaAniversario
    {
        private Repository repository = new Repository();

        public List<Pessoa> getLista(string procura = null)
        {
            List<Pessoa> listaFiltrada = new List<Pessoa>();
            List<Pessoa> pessoasList = repository.lerPessoas();
            if (string.IsNullOrEmpty(procura))
            {
                return pessoasList;
            }

            for (int i = 0; i < pessoasList.Count; i++)
            {
                string nomeCompleto = pessoasList[i].nome + " " + pessoasList[i].sobrenome;
                if (nomeCompleto.ToLower().Contains(procura.ToLower()))
                {
                    listaFiltrada.Add(pessoasList[i]);
                }
            }
            return listaFiltrada;
        }

        public Pessoa addLista(Pessoa pessoa)
        {
            return repository.adicionarPessoa(pessoa);
        }
        public void deleteFromLista(int id)
        {
            repository.deletarPessoa(id);
        }
        public void editFromLista(Pessoa pessoa)
        {
            repository.editarPessoa(pessoa);
        }

        public List<Pessoa> getAniversariantesDoDia()
        {
            List<Pessoa> listaFiltrada = new List<Pessoa>();
            List<Pessoa> pessoasList = repository.lerPessoas();


            pessoasList = pessoasList.Where(pessoa => pessoa.dataAniversario.Day == DateTime.Now.Day && pessoa.dataAniversario.Month == DateTime.Now.Month).ToList();

            return pessoasList;

        }
        public bool checarSeIdExiste(int id)
        {
            List<Pessoa> pessoasList = repository.lerPessoas();
            int indexExistente = pessoasList.FindIndex(p => p.id == id);
            if (indexExistente == -1)
            {
                return false;
            }
            return true;
        }
    }
}
