using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryEtapa5
{
    public class Pagamento
    {
        private decimal _valorpagamento;

        public decimal ValorPagamento 
        { 
            get
            {
                return _valorpagamento;            }
            set
            {
                _valorpagamento = value;
            }
        }
        public Pagamento(decimal valorpagamento)
        {
            _valorpagamento = valorpagamento;
        }
        public virtual decimal CalcularTaxa(decimal valor)
        {
            return valor * 3;
        }

        public virtual void EscreverValorPagamento()
        {
            Console.WriteLine("PAGANDO CONTA");
        }
    }
    public class PagamentoBoleto : Pagamento, ICalcularPagamento
    {
        private string _codigoDeBarra;

        public string CodigoDeBarra { get { return _codigoDeBarra; } set { } }

        public override decimal CalcularTaxa(decimal valor)
        {
            return valor * 5;
        }

        public PagamentoBoleto(string codigodebarra, decimal valorpagamento) : base(valorpagamento)
        {
            _codigoDeBarra = codigodebarra;
        }

        public override void EscreverValorPagamento()
        {
            Console.WriteLine("PAGANDO BOLETO");
        }

        public decimal CalcularPagamento()
        {
            return base.ValorPagamento * 10;
        }
    }

    public class PagamentoCartao:Pagamento, ICalcularPagamento
    {
        private string _nomeNoCartao;
        private Bandeiras _bandeira;

        public string NomeNoCartao { get { return _nomeNoCartao; } set { } }
        public Bandeiras Bandeira { get { return _bandeira; } set { } }

        public PagamentoCartao(string nomenocartao, Bandeiras bandeira, 
            decimal valorpagamento):base(valorpagamento)
        {
            _nomeNoCartao = nomenocartao;
            _bandeira = bandeira;
        }

        public override decimal CalcularTaxa(decimal valor)
        {
            return valor * 10;
        }

        public override void EscreverValorPagamento()
        {
            Console.WriteLine("PAGANDO CARTÃO");
        }

        public decimal CalcularPagamento()
        {
            return base.ValorPagamento * 30;
        }
    }
}