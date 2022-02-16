using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solucao_etapa3
{
    class BusinessException : Exception
    {
        public BusinessException(string Mensagem)
                 : base(Mensagem)
        {

        }
    }

}
