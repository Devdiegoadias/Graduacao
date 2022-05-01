// See https://aka.ms/new-console-template for more information
using TP3_CS;

void menu()
{
    Console.WriteLine("Gerenciador de aniversarios");
    Console.WriteLine("");
    Console.WriteLine("Selecione uma das opcoes abaixo");
    Console.WriteLine("1 - Adicionar Pessoa");
    Console.WriteLine("2 - Listar Pessoas");
    Console.WriteLine("3 - Procurar Pessoas");
    Console.WriteLine("");
    Console.WriteLine("Digite sua opcao:");

}

ListaAniversario listaAniversario = new ListaAniversario();

Pessoa perguntarPessoa()
{
    Pessoa pessoa = new Pessoa();
  
    DateTime data = new DateTime();
    Console.WriteLine("Escreva o Nome:");
    pessoa.nome = Console.ReadLine();

    Console.WriteLine("Escreva o Sobrenome:");
    pessoa.sobrenome = Console.ReadLine();


    Console.WriteLine("Escreva a data:");
    if (DateTime.TryParse(Console.ReadLine(), out data))
    {
        pessoa.dataAniversario = data;
    }
    else
    {
        throw new ArgumentException("Data invalida");
    }
    return pessoa;
}

TimeSpan diasRestantes(DateTime dataAniversario)
{
    DateTime hoje = DateTime.Now;
    DateTime proximoAniversario = new DateTime(hoje.Year, dataAniversario.Month, dataAniversario.Day);

    if (proximoAniversario < hoje)
        proximoAniversario = proximoAniversario.AddYears(1);

    return proximoAniversario - DateTime.Now;
}

void printPessoa(Pessoa pessoa)
{
    Console.WriteLine("Nome: " + pessoa.nome + " " + pessoa.sobrenome + " - Aniversario: " + pessoa.dataAniversario.ToString() + " - Dias restantes: " + diasRestantes(pessoa.dataAniversario).Days);
}

while (true)
{
    Console.Clear();
    menu();
    var opcao = Console.ReadLine(); 
    if(opcao == "1")
    {
        try
        {
            Pessoa pessoa = perguntarPessoa();
            listaAniversario.addLista(pessoa);
            Console.WriteLine("Pessoa cadastrada com sucesso!");
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    
    }
    if(opcao == "2")
    {
        var lista = listaAniversario.getLista();

        for (int i = 0; i < lista.Count; i++)
        { 
            printPessoa(lista[i]);
        }

    }
    if( opcao == "3")
    {
        Console.WriteLine("Digite o nome que deseja procurar");
        string nomeProcura = Console.ReadLine();
        var lista = listaAniversario.getLista(nomeProcura);

        for (int i = 0; i < lista.Count; i++)
        {
            printPessoa(lista[i]);
        }
    }
    Console.WriteLine("");
    Console.WriteLine("Qualquer tecla para continuar");
    Console.ReadLine();
}


