using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaCooknote
{
    public abstract class Receta
    {
        public List<Ingredientes> ingredientes { get; set; }
        public int id { get; set; }
        public string Nombre { get; set; }
        public DateTime FechaEliminacion { get; set; }
        public string NombreAutor { get; set; }


        public virtual string RetornarMensaje()
        {
            return (this.Nombre + " " + this.NombreAutor);
        }
    }
}
