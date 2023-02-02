namespace Entities
{
    public sealed class ExcursionPrivada : Excursion
    {
        public ExcursionPrivada(string id, string nombre, double tarifa, bool iva, int pasajeros, int baseveh) : base (id, nombre, tarifa, iva, pasajeros){
            BaseVehiculo = baseveh;
        }
        public int BaseVehiculo { get; set; }
        public void ChequeoBase(){
            if(BaseVehiculo < CantPasajeros)
                throw new Exception("La cantidad de pasajeros es mayor a la permitida en el vehículo para esta excursión");
        }
    }
}