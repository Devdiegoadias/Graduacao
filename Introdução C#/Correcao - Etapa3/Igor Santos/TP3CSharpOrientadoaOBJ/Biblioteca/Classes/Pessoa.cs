using System;
using System.Collections.Generic;
using System.Text;

namespace Biblioteca.Classes
{
    public class Pessoa
    {
            public string Nome { get; set; }
            public string Sobrenome { get; set; }
            public DateTime Nascimento { get; set; }
        

        public double tempo()
        {
            DateTime today = DateTime.Today;
            DateTime next = new DateTime(today.Year, Nascimento.Month, Nascimento.Day);
            if (next < today)
                next = next.AddYears(1);
            int numDays = (next - today).Days;

            return numDays;
           
        }



       
    }
}
