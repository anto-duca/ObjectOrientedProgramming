namespace Entities
{
public sealed class TrasladoRegular : Traslado
    {
        public  TrasladoRegular (string id, string nombre, bool iva, double tarifa, int tramos, int pasajeros) : base (id, nombre, iva, tarifa,tramos, pasajeros){
            
        }
    }
}