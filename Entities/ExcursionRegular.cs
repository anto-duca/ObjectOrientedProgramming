namespace Entities
{
    public sealed class ExcursionRegular : Excursion
    {
        public ExcursionRegular(string id, string nombre, double tarifa, bool iva,  int pasajeros, int minpasajeros): base (id, nombre, tarifa, iva, pasajeros){
            MinimoPasajeros = minpasajeros;
        }
        public int MinimoPasajeros { get; set; }
        public void ChequeoMinimoPasajeros(){
            if(CantPasajeros < MinimoPasajeros)
                throw new Exception("La excursión " + NombreServicio + " tiene un mínimo de " + MinimoPasajeros + " pasajeros");
        }
    }
}