namespace Entities
{
    public abstract class Traslado : IServicioTuristico
    {
        public Traslado(string id, string nombre, bool iva, double tarifa, int tramos, int pasajeros){
            Id = id;
            NombreServicio = nombre;
            IVAExento = iva;
            TarifaVenta = tarifa;
            CantTramos = tramos;
            CantPasajeros = pasajeros;
        }
        public string Id { get; set; }
        public string NombreServicio { get; set; }
        public bool IVAExento { get; set; }
        public double TarifaVenta { get; private set; }
        public int CantTramos { get; set; } // 1 tramo sería desde un aeropuerto al hotel y otro tramo sería del hotel al aeropuerto
        public int CantPasajeros { get; set; }
        public virtual double CalcularSubTotal(){
            double tarifa = 0;
            tarifa = TarifaVenta * CantTramos * CantPasajeros;
            return tarifa;
        }
    }
}