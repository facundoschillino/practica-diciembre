using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaCooknote
{
    public class RecetaCoctel:Receta
    {
        public override string RetornarMensaje()
        {
            return base.RetornarMensaje() + this.ingredientes.ToString();
        }
    }
}
