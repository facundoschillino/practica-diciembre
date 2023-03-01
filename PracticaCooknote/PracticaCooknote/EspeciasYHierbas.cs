using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaCooknote
{
    public class EspeciasYHierbas: Ingredientes
    {
        public string LugarOrigen { get; set; }
        public double gramos { get; set; }

        public Sabores sabor { get; set; }

    }
}
