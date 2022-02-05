using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlibioPessoas
{
    public class Pessoa
    {
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public DateTime Nascimento { get; set; }

        public Pessoa(string nome, string sobrenome, DateTime nascimento)
        {
            Nome = nome;
            Sobrenome = sobrenome;
            Nascimento = nascimento;
        }

        public int CalcularDataProximoAniversario()
        {
            DateTime dataAtual = DateTime.Today;
            DateTime proximaData = Nascimento.AddYears(dataAtual.Year - Nascimento.Year);

            if (proximaData < dataAtual)
                proximaData = proximaData.AddYears(1);

            int numeroDias = (proximaData - dataAtual).Days;

            return numeroDias;
        }

        public override string ToString()
        {
            return "\nNome do usuário selecionado: " + Nome + " " + Sobrenome + "\nData de nascimento: " + Nascimento;
        }
    }
}
