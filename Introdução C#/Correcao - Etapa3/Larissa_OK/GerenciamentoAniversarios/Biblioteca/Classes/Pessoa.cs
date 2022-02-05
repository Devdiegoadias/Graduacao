using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Biblioteca.Classes
{
    public class Pessoa
    {
        private string _nome;
        private string _sobrenome;
        [DataType(DataType.Date)]
        private DateTime _aniversario;

        #region Get and Set
        public string Nome
        {
            get { return _nome; }
            set { _nome = value; }
        }
        public string Sobrenome
        {
            get { return _sobrenome; }
            set { _sobrenome = value; }
        }
        public DateTime Aniversario
        {
            get { return _aniversario; }
            set { _aniversario = value; }
        }
        #endregion

        public Pessoa() { }
        public Pessoa(string nome, string sobrenome, DateTime aniversario)
        {
            _nome = nome;
            _sobrenome = sobrenome;
            _aniversario = aniversario;
        }

        public static void ProxAniversario(DateTime aniversario)
        {
            DateTime hoje = DateTime.Now.Date;
            DateTime proxNiver = new DateTime(DateTime.Now.Year + 1, aniversario.Month, aniversario.Day);
            Console.Write($"Faltam {(proxNiver - hoje).TotalDays} dias para seu próximo aniversário");
        }

    }

}
