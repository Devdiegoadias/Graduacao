using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryEtapa5
{
    public class Territorio
    {
        public virtual void RetornaNome() { }
    }

    public class Reinado:Territorio
    {
         public override void RetornaNome()
        {
            
        }
    }

    public  class Principado:Reinado
    {
        public override void RetornaNome() { }
    }

    public class Condado:Principado
    {

    }

    public class Pai
    {
        private float _cpf;
        private string _rg;

        public string RG
        {
            set { _rg = value; }
        }

        public virtual void DizerOi() { }
        
    }

    public class Filho:Pai
    {
         public override void DizerOi(){}
    }

    public class Neto : Filho
    {
        public override void DizerOi() { }
    }



}
