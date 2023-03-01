using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaCooknote
{
    public abstract class Usuario
    {
        public string Nombre { get; set; }
        public int Codigo { get; set; }
        public string Nickname { get; set; }
        public string Password { get; set; }
        
    }
}
