namespace ClassLibrary1
{
    public class Pessoa
    {
        private int _id;
        private string _nome;
        private string _sobrenome;
        private DateTime _aniversario;
        DateTime hoje = DateTime.Now;


        public Pessoa(int id, string nome, string sobrenome, DateTime aniversario)
        {
            _id = id;
            _nome = nome;
            _sobrenome = sobrenome;
            _aniversario = aniversario;
        }

        public int Id { get { return _id; } }

        public string Nome { get { return _nome; }  }

        public string Sobrenome { get { return _sobrenome; }  }
        public DateTime Aniversario { get { return _aniversario; }  }

        public string diasParaAniversario()
        {
            DateTime dataNascimento2 = _aniversario;
            dataNascimento2 = new DateTime(hoje.Year, dataNascimento2.Month, dataNascimento2.Day);
            TimeSpan diferencaDatas = dataNascimento2.Subtract(hoje);
            int diasFaltantes = diferencaDatas.Days;

            if (diasFaltantes > 0)
            {
                return $"\n{_id} - {_nome} {_sobrenome} faz aniversario em {_aniversario}"
                + $"\nFaltam {diasFaltantes} dias para seu aniversario.";
            }
            else if (diasFaltantes == 0)
            {
                return $"\n{_id} - {_nome} {_sobrenome} faz aniversario em {_aniversario}"
                + $"\nSeu aniversário é hoje. Dê parabéns!";
            }
            else
            {
                return $"\n{_id} - {_nome} {_sobrenome} faz aniversario em {_aniversario}"
                + $"\nSeu aniversario foi há {-diasFaltantes} dias.";
            }
        }
    }
}
