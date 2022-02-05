using System;

namespace TP3
{
    class Pessoa
    {
        private string _nome;
        private string _sobrenome;
        private DateTime _data;

        public Pessoa(string _nome, string _sobrenome, DateTime _data)
        {
            Nome = _nome;
            Sobrenome = _sobrenome;
            data = _data;
        }

        public string Nome
        {
            get
            {
                return _nome;
            }
            set
            {
                _nome = value;
            }
        }

        public string Sobrenome
        {
            get
            {
                return _sobrenome;
            }
            set
            {
                _sobrenome = value;
            }
        }

        public DateTime data
        {
            get
            {
                return _data;
            }
            set
            {
                _data = value;
            }
        }

        public override string ToString()
        {
            return Nome + " " + Sobrenome + " " + data;
        }
    }
}

