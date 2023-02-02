namespace Entities
{
    public sealed class Lodge : Alojamiento
    { 
        public Lodge(string id, string nombre, int tarifa, bool iva, PaqueteNoches noches, int cantpasajeros): base (id, nombre, tarifa, iva){
            PaqueteLodge = noches;
            CantPasajeros = cantpasajeros;
        }
        public Lodge(string id, string nombre, int tarifa, bool iva, bool minimogrupo, PaqueteNoches noches, int cantpasajeros): base (id, nombre, tarifa, iva, minimogrupo){
            PaqueteLodge = noches;
            CantPasajeros = cantpasajeros;
        }
        public int CantPasajeros { get; set; }
        public enum PaqueteNoches{
            DosNoches,
            TresNoches,
            CuatroNoches,
            CincoNoches
        }
        public PaqueteNoches PaqueteLodge { get; set; }
        public override double CalcularSubTotal()
        {
            double tarifa = 0;
            if(MinimoGrupo)
                throw new Exception("El lodge " + NombreServicio + " cuenta con política de grupos de pasajeros");
            else {
                tarifa = TarifaVenta * CantPasajeros;
            return tarifa;
            }
        }
    }
}