namespace PracticaCooknote
{
    public class RecetaCocina: Receta
    {
        public override string RetornarMensaje()
        {
            return (base.RetornarMensaje() + " " + this.ingredientes[0].Nombre+ "," + this.ingredientes[1].Nombre + "," + this.ingredientes[2].Nombre);
        }
    }
}
