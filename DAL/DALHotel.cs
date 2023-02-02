using Entities;
using System.Data;
using System.Data.SqlClient;

namespace DAL;
public class DALHotel
{
    Datos datos;
    public DALHotel(){
        datos = new Datos();
    }
    public void InsertarHotel(Hotel hotel){
        var consulta = "insert into hoteles(Id, Nombre, Tarifa, Iva, CantidadNoches, MinimoGrupo) values(@id, @nombre, @tarifa, @iva, @cantidad, @minimo)";
        datos.EjecutarConsultaSinResultado(consulta, MostrarParametros(true, hotel));
    }
    public void ModificarHotel(Hotel hotel){
        var consulta = "update hoteles set nombre=@nombre, tarifa=@tarifa, iva=@iva, CantidadNoches=@cantidad, MinimoGrupo=@minimo where id=@id";
        datos.EjecutarConsultaSinResultado(consulta, MostrarParametros(true, hotel));
    }
    public void BorrarHotel(Hotel hotel){
        var consulta = "delete hoteles where id=@id";
        datos.EjecutarConsultaSinResultado(consulta, MostrarParametros(false, hotel));
    }
    public List<Hotel>MostrarHoteles(){
        var hoteles = new List<Hotel>();
        var consulta = "select * from hoteles";
        DataTable dt = datos.MostrarDatos(consulta, null);
        foreach (DataRow dr in dt.Rows)
        {
            var hotel = new Hotel();
            hotel.Id = (string)dr["Id"];
            hotel.NombreServicio = (string)dr["Nombre"];
            hotel.IVAExento = (bool)dr["Iva"];
            hotel.CantNoches = (int)dr["CantidadNoches"];
            hotel.MinimoGrupo = (bool)dr["MinimoGrupo"];
            hoteles.Add(hotel);
        }
        return hoteles;
    }
    public Hotel MostrarHotelId(string id){
        var hotel = new Hotel();
        var consulta = "select * from hoteles where id=@id";
        DataTable dt = datos.MostrarDatos(consulta, new SqlParameter("id", id));
        foreach (DataRow dr in dt.Rows)
        {
            hotel.Id = (string)dr["Id"];
            hotel.NombreServicio = (string)dr["Nombre"];
            hotel.IVAExento = (bool)dr["Iva"];
            hotel.CantNoches = (int)dr["CantidadNoches"];
            hotel.MinimoGrupo = (bool)dr["MinimoGrupo"];
        }
        return hotel;
    }
    private SqlParameter[] MostrarParametros(bool insUpd, Hotel hotel)
    {
        var paramId = new SqlParameter("@id", hotel.Id);
        var paramNombre = new SqlParameter("@nombre", hotel.NombreServicio);
        var paramTarifa = new SqlParameter("@tarifa", hotel.TarifaVenta);
        var paramIva = new SqlParameter("@iva", hotel.IVAExento);
        var paramCantidad = new SqlParameter("@cantidad", hotel.CantNoches);
        var paramMinGrup = new SqlParameter("@minimo", hotel.MinimoGrupo);
        if(insUpd)
            return new SqlParameter[]{paramId, paramNombre, paramTarifa, paramIva, paramCantidad, paramMinGrup};
        return new SqlParameter[]{paramId};
    }
}
