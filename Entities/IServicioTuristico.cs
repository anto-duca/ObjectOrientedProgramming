namespace Entities
{
    public interface IServicioTuristico
    {
        string Id { get; set; }
        string NombreServicio { get; set; }
        bool IVAExento { get; set; }
        double CalcularSubTotal();
    }
}