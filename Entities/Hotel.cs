namespace Entities
{
public sealed class Hotel : Alojamiento
    {
        public Hotel(){
            Habitaciones =  new List<Habitacion>();
        }
        public Hotel (string id, string nombre, int tarifa, bool iva, int cantNoches) : base (id, nombre, tarifa, iva){
            Habitaciones =  new List<Habitacion>();
            CantNoches = cantNoches;
        }
        public Hotel (string id, string nombre, int tarifa, bool iva, bool minimogrupo, int cantNoches) : base (id, nombre, tarifa, iva, minimogrupo){
            Habitaciones =  new List<Habitacion>();
            CantNoches = cantNoches;
        }
        private List<Habitacion> Habitaciones;
        public int CantNoches { get; set; }
        public int TotalHab{
            get{
                if(this.Habitaciones.Count == 0)
                    throw new Exception("No se agregaron habitaciones en el Hotel: "  + NombreServicio);
                else {
                    int cantHab = this.Habitaciones.Count;
                    return cantHab;
                }
            }
        }
        public void AgregarHabitaciones(Habitacion habitacion){
            this.Habitaciones.Add(habitacion);
        }
        public override double CalcularSubTotal(){
            double tarifa = 0;
            if(MinimoGrupo)
                throw new Exception("El hotel " + NombreServicio + " cuenta con política de grupos");
            else
                tarifa = ( TarifaVenta * CantNoches * TotalHab);
            return tarifa;
        }
    }
}