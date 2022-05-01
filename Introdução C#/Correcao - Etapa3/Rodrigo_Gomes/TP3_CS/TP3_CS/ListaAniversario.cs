using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP3_CS
{
    internal class ListaAniversario
    {
        private List<Pessoa> pessoasList = new List<Pessoa>();

        public List<Pessoa> getLista(string procura = null)
        {
            List<Pessoa> listaFiltrada = new List<Pessoa>();

            if (string.IsNullOrEmpty(procura))
            {
                return pessoasList;
            }
            for (int i = 0; i < pessoasList.Count; i++) 
            {
                string nomeCompleto = pessoasList[i].nome + " " + pessoasList[i].sobrenome;
                if (nomeCompleto.ToLower().Contains(procura.ToLower()))
                {
                    listaFiltrada.Add(pessoasList[i]);
                }
            }
            return listaFiltrada;
        }
        public List<Pessoa> g()
        {
            return pessoasList; 
        }

        public Pessoa addLista(Pessoa pessoa)
        {
            if (string.IsNullOrEmpty(pessoa.nome))
            {
                Console.WriteLine("Nome obrigatorio");
            }
            pessoasList.Add(pessoa);

            return pessoa;
        }
    }
}
