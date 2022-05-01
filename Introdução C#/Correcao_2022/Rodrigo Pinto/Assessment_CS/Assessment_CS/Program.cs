// See https://aka.ms/new-console-template for more information
using BibliotecaAssessment;

void menu()
{
    Console.WriteLine("Gerenciador de aniversarios");
    Console.WriteLine("");
    Console.WriteLine("Selecione uma das opcoes abaixo");
    Console.WriteLine("1 - Adicionar Pessoa");
    Console.WriteLine("2 - Listar Pessoas");
    Console.WriteLine("3 - Procurar Pessoas");
    Console.WriteLine("4 - Deletar Pessoa por Id");
    Console.WriteLine("5 - Editar Pessoa por Id");
    Console.WriteLine("");
    Console.WriteLine("Digite sua opcao:");
}

ListaAniversario listaAniversario = new ListaAniversario();

void imprimirAniversariantesDoDia()
{
    var lista = listaAniversario.getAniversariantesDoDia();
    if (lista.Count == 0)
    {
        Console.WriteLine("Sem aniversariantes Hoje");
        Console.WriteLine("");
        return;
    }
    Console.WriteLine("Aniversariantes do dia: " + lista.Count);
    foreach (var pessoa in lista)
    {
        printPessoa(pessoa);
    }
    Console.WriteLine("");

}

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
    Console.WriteLine("Id: " + pessoa.id + " Nome: " + pessoa.nome + " " + pessoa.sobrenome + " - Aniversario: " + pessoa.dataAniversario.ToString() + " - Dias restantes: " + diasRestantes(pessoa.dataAniversario).Days);
}


imprimirAniversariantesDoDia();
while (true)
{
    menu();
    var opcao = Console.ReadLine();
    if (opcao == "1")
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
    if (opcao == "2")
    {
        var lista = listaAniversario.getLista();

        for (int i = 0; i < lista.Count; i++)
        {
            printPessoa(lista[i]);
        }

    }


    if (opcao == "3")
    {
        Console.WriteLine("Digite o nome que deseja procurar");
        string nomeProcura = Console.ReadLine();
        var lista = listaAniversario.getLista(nomeProcura);

        if (lista.Count == 0)
        {
            Console.WriteLine("Nenhuma pessoa encontrada");
        }
        else
        {
            for (int i = 0; i < lista.Count; i++)
            {
                printPessoa(lista[i]);
            }
        }
    }
    if (opcao == "4")
    {
        Console.WriteLine("Digite o id da pessoa que deseja remover");
        string id = Console.ReadLine();

        Boolean idExiste = listaAniversario.checarSeIdExiste(int.Parse(id));

        if (idExiste == false)
        {
            Console.WriteLine("Id inexistente");
        }
        else
        {
            listaAniversario.deleteFromLista(int.Parse(id));
        }
    }

    if (opcao == "5")
    {
        Console.WriteLine("Digite o id da pessoa que deseja Editar");
        string id = Console.ReadLine();

        Boolean idExiste = listaAniversario.checarSeIdExiste(int.Parse(id));

        if (idExiste == false)
        {
            Console.WriteLine("Id inexistente");
        }
        else
        {
            try
            {
                Pessoa pessoa = perguntarPessoa();

                pessoa.id = int.Parse(id);
                listaAniversario.editFromLista(pessoa);
                Console.WriteLine("Pessoa editada com sucesso!");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }

    Console.WriteLine("");
    Console.WriteLine("Qualquer tecla para continuar");
    Console.ReadLine();
    Console.Clear();
}


