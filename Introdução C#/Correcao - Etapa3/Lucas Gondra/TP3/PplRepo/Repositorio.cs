using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace PplRepo
{
    public class Repositorio
    {
        private List<Pessoa> ppllist = new List<Pessoa>();
        Pessoa p1 = new Pessoa("lucas", "gondra", new DateTime(1997, 05, 12));
        public Repositorio() 
        {
            this.ppllist.Add(p1);
        }

        public void Addppl()
        {
            Console.WriteLine(" Digite o nome:");
            string nome = Console.ReadLine();
            Console.WriteLine(" Digite o sobrenome:");
            string sobrenome = Console.ReadLine();
            Console.WriteLine(" Digite a data de nascimentono formato dd/mm/aaaa:");
            string nascimento = Console.ReadLine();
            DateTime n4sc1m3nt0 = Convert.ToDateTime(nascimento);
            Pessoa px = new Pessoa(nome, sobrenome, n4sc1m3nt0);
            Console.WriteLine(" Os dados abaixo estao corretos? \n" +
                    " Nome: " + px.Nome + px.Sobrenome + "\n" +
                    " Data de nascimento: " + px.Nascimento + "\n" +
                    " 1 - Sim \n" +
                    " 2 - Nao \n");
            switch (Console.ReadLine())
            {
                case "1":
                    Console.WriteLine("Dados adicionados com sucesso");
                    break;
                case "2":
                    Console.WriteLine("Tente novamente");
                    break;
                default:
                    break;
            }
            this.ppllist.Add(px);
        }
        public void Search()
        {
            Console.WriteLine(" Digite o nome ou parte do nome para pesquisar: ");
            string namesearch = Console.ReadLine();
            Console.WriteLine(" Selecione uma das opcoes para ver os dados: ");
            int c = 1;
            foreach (Pessoa p in ppllist)
            {
                if (p.Nome.Contains(namesearch))
                {
                    Console.WriteLine(c + " - " + p.Nome + " " + p.Sobrenome);
                }
                c += 1;
            }
            c = int.Parse(Console.ReadLine());

            Console.WriteLine(" Dados da pessoa: \n" +
                " Nome completo: " + ppllist[c - 1].Nome + " " + ppllist[c - 1].Sobrenome + "\n" +
                " Data de nascimento: " + ppllist[c - 1].Nascimento + "\n" +
                "faltam " + ppllist[c - 1].DaysToNiver().Days + " dias para o proximo aniversario");
        }
    }
}
