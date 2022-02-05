using System;
using System.Collections.Generic;
using System.Text;

namespace $safeprojectname$
{
    public class pessoa
    {
        private string _nome;
        private int _data;


        public pessoa(string _nome, int _data)
        {
            Nome = _nome;
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

        public int data
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
            return Nome + " " + data; ;
        }


    }
}
