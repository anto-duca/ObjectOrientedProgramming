using DAL;
using Entities;

namespace BLL;
public class BLLHotel
{
    public void Insertar(Hotel hotel)
    {
        var dalHot = new DALHotel();
        dalHot.InsertarHotel(hotel);
    }
    public void Actualizar(Hotel hotel)
    {
        var dalHotel = new DALHotel();
        dalHotel.ModificarHotel(hotel);
    }
    public void Eliminar(Hotel hotel)
    {
        var dalHotel = new DALHotel();
        dalHotel.BorrarHotel(hotel);
    }
    public List<Hotel>Listar()
    {
        var dalHotel = new DALHotel();
        return dalHotel.MostrarHoteles();
    }
    public List<Hotel>HotelesIVAExento()
    {
        var hotelesUSH = Listar().Where(x => x.IVAExento == true).ToList();
        return hotelesUSH;
    }
    public Hotel MostrarUnHotel(string id)
    {
        var dalHotel = new DALHotel();
        return dalHotel.MostrarHotelId(id);
    }
}
