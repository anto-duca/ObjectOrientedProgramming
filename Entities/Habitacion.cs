namespace Entities
{
    public sealed class Habitacion
    {
        public Habitacion (BaseHab basehab, int cantidad){
            CatHabitacion = basehab;
            CantHab = cantidad;
        }
        public enum BaseHab{
            BaseSingle,
            BaseDoble,
            BaseTriple,
            BaseCuadruple
        }
        public BaseHab CatHabitacion { get; set; }
        public int CantHab { get; set; }
    }
}