using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaCooknote
{
    public class Vip: Usuario
    {
        public Paises pais { get; set; }

        public List<int> IngredientesFavoritos { get; set; }
        public List<string> UsuariosFavoritos { get; set; }
        public List<int> RecetasFavoritas { get; set; }

        public Vip() {}

        public Vip (string name, string pswrd, string nickname, int codigo, Paises pais)
        {
            this.Nombre = name;
            this.Password = pswrd;
            this.Nickname = nickname;
            this.Codigo = codigo;
            this.pais = pais;
        }
    }
}
