namespace ClassLibrary1
{
    public class Mensagem
    {
        public string principal()
        {
            return "Gerenciador de Aniversários\n" +
                        "Bem vindo. Por favor, selecione uma das opções abaixo.\n"
                          + "1 - Adicionar novas pessoas\n"
                          + "2 - Pesquisar pessoas\n"
                          + "3 - Sair\n";
        }
        public string pesquisa()
        {
            return "\nGerenciador de Aniversários\n" +
                        "Digite o nome, ou parte do nome, da pessoa que deseja encontrar:\n";
        }
    }

}