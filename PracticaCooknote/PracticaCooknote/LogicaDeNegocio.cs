using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaCooknote
{
    public class LogicaDeNegocio
    {
        public List<Usuario> Usuarios = new List<Usuario>();
        public List<Receta> Recetas = new List<Receta>();
        public List<Ingredientes> Despensa = new List<Ingredientes>();

        public int validaruser(string nickname, string pswrd)
        {
            int index = Usuarios.FindIndex(x => x.Nickname == nickname);
            if (Usuarios[index].Password == pswrd)
            {
                return index;

            }
            else return -1;
        }

        public void CargaUser(string Nombre, string pswrd, string Nickname, bool vip, Paises pais)
        {
            if (vip)
            {
                //if Check Pais
                Vip User = new Vip(Nombre, pswrd, Nickname, Usuarios.Count() + 1, pais);
                User.IngredientesFavoritos = new List<int> { };
                User.UsuariosFavoritos = new List<string>();
                Usuarios.Add(User);
            }
            else
            {
                Normal User = new Normal();
                User.Nombre = Nombre;
                User.Password = pswrd;
                User.Nickname = Nickname;
                User.Codigo = Usuarios.Count();
                Usuarios.Add(User);
            }
        }
        public void CargaUser(string nickname, string pswrd, int numero)
        {
            foreach (Receta receta in Recetas)
            {
                if (receta.id == numero)
                {
                    int index = validaruser(nickname, pswrd);
                    if (index > 0)
                    {
                        Vip vip = new Vip();
                        vip.RecetasFavoritas.Add(numero);
                        Usuarios[index] = vip;
                        break;
                    }
                }
            }
        }
        public void CargaUser(string nickname, string pswrd, string Nickname)
        {
            int index = validaruser(nickname, pswrd);
            if (index > 0)
            {
                Vip vip = new Vip();
                vip.UsuariosFavoritos.Add(Nickname);
                Usuarios[index] = vip;
            }
        }
        public List<Receta> FiltroRecetas(string Clave, string NickName, string pswrd)
        {

            List<Receta> recetas = new List<Receta>();
            int index = validaruser(NickName, pswrd);
            if (index > 0)
            {
                foreach (Receta receta in Recetas)
                {
                    if (receta.Nombre.ToUpper().Contains(Clave.ToUpper()))
                    {
                        recetas.Add(receta);
                    }
                    else
                    {
                        foreach (Ingredientes ingrediente in receta.ingredientes)
                        {
                            if (ingrediente.Nombre.ToUpper().Contains(Clave.ToUpper()))
                            {
                                recetas.Add(receta);
                                break;
                            }
                        }
                    }
                }

                return recetas;
            }
            else return null;

        }
        public List<string> RetornarIngredientes()
        {
            List<string> retornar = new List<string>();
            foreach (Ingredientes ingrediente in Despensa)
            {
                retornar.Add(ingrediente.Descripcion);
            }
            return retornar;
        }
    }
}
