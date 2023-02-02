namespace Entities
{
    public abstract class Excursion : IServicioTuristico
    {
        public Excursion(string id, string nombre, double tarifa, bool iva, int pasajeros){
            Id = id;
            NombreServicio = nombre;
            TarifaVenta = tarifa;
            IVAExento = iva;
            CantPasajeros = pasajeros;
        }
        public string Id { get; set; }
        public string NombreServicio { get; set; }
        public bool IVAExento { get; set; }
        public double TarifaVenta { get; private set; }
        public int CantPasajeros { get; set; }
        public virtual double CalcularSubTotal(){
            double tarifa = 0;
            tarifa = TarifaVenta * CantPasajeros;
            return tarifa;
        }
    }
}