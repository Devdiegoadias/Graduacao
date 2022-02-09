class etapa2
{  
    static void Main()
    {
        //Sobre atribuição(=), impressão (console.writeLine)  e concatenação ($ e o +)

        string? nome;
        string? sobreNome;

        /*
         Console.WriteLine("Digite seu nome:");
         nome = Console.ReadLine();

         if(nome != null && nome != string.Empty)
         {
             Console.WriteLine("O nome é:" + nome);
         }
         else
         {
             Console.WriteLine("Nome inválido");
         }

         Console.WriteLine("Digite o seu sobrenome");
         sobreNome = Console.ReadLine();

         Console.WriteLine($"Olá {nome} {sobreNome} !");

         Console.WriteLine("Olá " + nome + " " + sobreNome);
        */

        //Operadores aritméticos

        //soma +
        //multiplicação *
        //divisão /
        //subtração -

        int num1;
        int num2;

        Console.WriteLine("Digite o primeiro número:");
        num1 = int.Parse(Console.ReadLine());

        Console.WriteLine("Digite o segundo número:");
        num2 = int.Parse(Console.ReadLine());

        Operacoes op = new Operacoes();
        
        Console.Write("A soma de " + num1 + " com " + num2 + ": "); op.soma(num1, num2);
        Console.Write("A subtracao de " + num1 + " com " + num2 + ": "); op.subtracao(num1, num2);
        Console.Write("A multiplicacao de " + num1 + " com " + num2 + ": "); op.multiplicacao(num1, num2);
        Console.Write("A divisao de " + num1 + " com " + num2 + ": "); op.divisao(num1, num2);

        Console.ReadKey();
    }
}