using System;

namespace PplRepo
{
    public class Pessoa
    {
        private string _nome;
        private string _sobrenome;
        private DateTime _nascimento;

        #region getset
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
        public DateTime Nascimento
        {
            get { return _nascimento; }
            set { _nascimento = value; }
        }
        #endregion

        public Pessoa(string nome, string sobrenome, DateTime nascimento)
        {
            _nome = nome;
            _sobrenome = sobrenome;
            _nascimento = nascimento;
        }

        public TimeSpan DaysToNiver()
        {
            DateTime proxniver = new DateTime(DateTime.Now.Year + 1, Nascimento.Month, Nascimento.Day);

            return proxniver.Subtract(DateTime.Now);
        }
    }
}
