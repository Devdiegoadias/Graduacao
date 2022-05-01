
namespace BibliotecaAssessment
{
    public interface IRepository
    {
        List<Pessoa> lerPessoas();

        Pessoa adicionarPessoa(Pessoa pessoa);

        void deletarPessoa(int id);

        void editarPessoa(Pessoa pessoa);
    }
}
