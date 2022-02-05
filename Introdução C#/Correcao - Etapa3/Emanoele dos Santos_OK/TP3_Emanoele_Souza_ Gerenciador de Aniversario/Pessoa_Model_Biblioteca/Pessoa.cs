using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pessoa_Model_Biblioteca
{
    public class Pessoa
    {
        private string _nome;
        private string _sobreNome;
        private DateTime _dateTime;

        public string Nome
        {
            get { return _nome; }
            set { _nome = value; }
        }
        public string SobreNome
        {
            get { return _sobreNome; }
            set { _sobreNome = value; }
        }
        public DateTime DataAniversario
        {
            get { return _dateTime; }
            set { _dateTime = value; }
        }
        public static object TempoParaOProximoAniversario(DateTime aniversario)
        {
            var calcularData = aniversario.AddYears(DateTime.Today.Year - aniversario.Year);

            if (calcularData < DateTime.Today)
            {
                calcularData = calcularData.AddYears(1);
            }
            return (calcularData - DateTime.Today).Days;
        }
    }
}
