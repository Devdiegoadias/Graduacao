using System;
using System.Collections.Generic;
using System.Text;

namespace aulacsharp9do11.Classes
{
    public class Eletronico
    {
        private string _nome;
        private decimal _valor;
        private readonly Tensao _tensao;
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

        public decimal Valor
        {
            get
            {
                return _valor;
            }
            set
            {
                _valor = value;
            }
        }


        public enum Tensao
        {
            v110 = 110,
            v220 = 220
        }

        public Eletronico(string nome, decimal valor, Tensao tensao) //construtor
        {
            _nome = nome;
            _valor = valor;
            _tensao = tensao;
        }

    }
}
