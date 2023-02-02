namespace Entities
{
public abstract class Alojamiento : IServicioTuristico
    {
        public Alojamiento(){
            
        }
        public Alojamiento(string id, string nombre, int tarifa, bool iva){
            Id = id;
            NombreServicio = nombre;
            TarifaVenta = tarifa;
            IVAExento = iva;
        }
        public Alojamiento(string id, string nombre, int tarifa, bool iva, bool minimogrupo) : this(id, nombre, tarifa, iva){
            MinimoGrupo = minimogrupo;
        }
        public string Id { get; set; }
        public string NombreServicio { get; set; }
        public bool IVAExento { get; set; }
        public double TarifaVenta { get; private set; }
        public bool MinimoGrupo { get; set; } //opcional no todos los alojamientos manejan tarifas de grupos
        public abstract double CalcularSubTotal();
    }
}