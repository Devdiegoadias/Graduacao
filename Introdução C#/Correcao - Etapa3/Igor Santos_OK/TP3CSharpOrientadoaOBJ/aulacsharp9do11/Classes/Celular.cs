using System;
using System.Collections.Generic;
using System.Text;

namespace aulacsharp9do11.Classes
{
    public class Celular : Eletronico
    {
        private Marcas _marca;
        public enum Marcas
        {
            Apple = 1,
            Samsung = 2,
            Xiaomi = 3,
        }

        public Celular(string nome, decimal valor, Tensao tensao, Marcas marcas) :base(nome, valor, tensao)
        {
            _marca = Marcas;
        }
    }
}
