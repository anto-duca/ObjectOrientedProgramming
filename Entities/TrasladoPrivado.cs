namespace Entities
{
    public sealed class TrasladoPrivado : Traslado
    {
        public TrasladoPrivado (string id, string nombre, bool iva,  double tarifa, int tramos, int pasajeros, int baseveh) : base (id, nombre, iva, tarifa,  tramos, pasajeros){
            BaseVehiculo = baseveh;
        }
        public int BaseVehiculo { get; set; }
        public override double CalcularSubTotal(){
            ChequeoTraslado();
            double tarifa = 0;
            tarifa = TarifaVenta * CantTramos;
            return tarifa;
        }
        public void ChequeoTraslado(){
            if(BaseVehiculo < CantPasajeros)
                throw new Exception("La cantidad de pasajeros es mayor a la permitida en el vehículo");
        }
    }
}