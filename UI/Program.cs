using System;
using Entities;
using BLL;

namespace Programa
{
    class Program
    {
        static void Main(string[] args)
        {
            // // PRUEBA CARRITO 1: PAQUETE IGUAZÚ Y ESTEROS DEL IBERA CON TRASLADOS Y EXCURSION EN PRIVADO
            // try
            // {
            //     // Agrego el primer alojamiento del tipo Lodge
            //     var lodge1 = new Lodge("Ñande Retá Lodge", 25000, false, Lodge.PaqueteNoches.CincoNoches, 2);

            //     // Agrego el segundo alojamiento del tipo hotel
            //     var hotel1 = new Hotel("Hotel O2 Iguazú", 20000, false, 3);
            //     var hab1 = new Habitacion(Habitacion.BaseHab.BaseSingle, 1);
            //     var hab2 = new Habitacion(Habitacion.BaseHab.BaseSingle, 1);
            //     hotel1.AgregarHabitaciones(hab1);
            //     hotel1.AgregarHabitaciones(hab2);

            //     // agrego un traslado privado, en este caso es correcto son 2 tramos, para 2 pasajeros y el vehículo permite a 2 pasajeros.
            //     var traslado1 = new TrasladoPrivado("Traslado APT a HTL IGUAZU", false, 800,  1, 2, 2);

            //     // agrego una excursión privada, 
            //     var excursion1 = new ExcursionPrivada("Excursion Cataratas Argentinas", 4000, false, 2, 2);

            //     //agrego los servicios al carrito
            //     var carrito = new Carrito();
            //     carrito.AgregarServicios(lodge1);
            //     carrito.AgregarServicios(hotel1);
            //     carrito.AgregarServicios(traslado1);
            //     carrito.AgregarServicios(excursion1);
            //     var totalCarrito = carrito.TotalCarrito();
            //     carrito.MostrarCarrito();
            //     Console.WriteLine("TOTAL CARRITO 1: " + totalCarrito);
            //     Console.WriteLine("----------------------------------");
            // }
            // catch (Exception e)
            // {
            //     Console.WriteLine("Error: " + e.Message.ToString());
            // }

            // // PRUEBA 2: HOTEL SIN HABITACIONES AGREGADAS
            // try
            // {
            //     // agrego un hotel en Ushuaia, sin habitaciones para que arroje un error
            //     var hotel2 = new Hotel("Hotel Ushuaia", 15000, true, 4);

            //     //agrego los servicios al carrito
            //     var carrito = new Carrito();
            //     carrito.AgregarServicios(hotel2);
            //     var totalCarrito = carrito.TotalCarrito();
            //     carrito.MostrarCarrito();
            //     Console.WriteLine("TOTAL CARRITO 2: " + totalCarrito);
            //     Console.WriteLine("----------------------------------");
            // }
            // catch (Exception e)
            // {
            //     Console.WriteLine("Error: " + e.Message.ToString());
            // }

            // // PRUEBA 3: TRASLADO PRIVADO CON MAYOR CANTIDAD DE PASAJEROS QUE SU CAPACIDAD PERMITIDA
            // try
            // {
            //     // Agrego un traslado privado donde la cantidad de pasajeros es mayor a la cantidad de pasajeros permitida por el vehículo
            //     var traslado2 = new TrasladoPrivado("Traslado privado APT a HTL USH", true, 2500, 2, 4, 2);

            //     var carrito = new Carrito();
            //     carrito.AgregarServicios(traslado2);
            //     var totalCarrito = carrito.TotalCarrito();
            //     carrito.MostrarCarrito();
            //     Console.WriteLine("TOTAL CARRITO 3: " + totalCarrito);
            //     Console.WriteLine("----------------------------------");
            // }
            // catch (Exception ex)
            // {
            //     Console.WriteLine("Error: " + ex.Message.ToString());
            // }

            // // PRUEBA 4: PAQUETE USHUAIA: IVA EXENTO
            // try
            // {
            //     var hotelUsh = new Hotel("Hotel Ushuaia", 20000, true, 2);
            //     var habUsh = new Habitacion(Habitacion.BaseHab.BaseDoble, 1);
            //     hotelUsh.AgregarHabitaciones(habUsh);

            //     var trfush = new TrasladoRegular("Traslado Aeropuerto a Hotel", true, 800, 2, 2);

            //     var excUsh = new ExcursionRegular("Parque Nacional", 750, true, 2, 0);

            //     var carritoUsh = new Carrito();
            //     carritoUsh.AgregarServicios(hotelUsh);
            //     carritoUsh.AgregarServicios(trfush);
            //     carritoUsh.AgregarServicios(excUsh);
            //     var totalCarritoUsh = carritoUsh.TotalCarrito();
            //     carritoUsh.MostrarCarrito();
            //     Console.WriteLine("TOTAL CARRITO 4: " + totalCarritoUsh);
            //     Console.WriteLine("----------------------------------");
            // }
            // catch (Exception e)
            // {
            //     Console.WriteLine("Error: " + e.Message.ToString());
            // }

            // // PRUEBA 5: PAQUETE CALAFATE CON TRASLADOS Y EXCURSIONES EN REGULAR
            // try
            // {
            //     var hotelFte = new Hotel("Hotel Calafate", 20000, false, 2);
            //     var habFte = new Habitacion(Habitacion.BaseHab.BaseDoble, 1);
            //     hotelFte.AgregarHabitaciones(habFte);

            //     var trfFte = new TrasladoRegular("Traslado Aeropuerto a Hotel", false, 1000, 2, 2);

            //     var excFte = new ExcursionRegular("Parque Nacional Los Glaciares", 750, false, 2, 0);

            //     var carritoFte = new Carrito();
            //     carritoFte.AgregarServicios(hotelFte);
            //     carritoFte.AgregarServicios(trfFte);
            //     carritoFte.AgregarServicios(excFte);
            //     var totalCarritoFte = carritoFte.TotalCarrito();
            //     carritoFte.MostrarCarrito();
            //     Console.WriteLine("TOTAL CARRITO 5: " + totalCarritoFte);
            //     Console.WriteLine("----------------------------------");
            // }
            // catch (Exception e)
            // {
            //     Console.WriteLine("Error: " + e.Message.ToString());
            // }

            // // PRUEBA 6: HOTEL CON MÍNIMO DE GRUPO
            // try
            // {
            //     // Agrego el segundo alojamiento del tipo hotel
            //     var hotelPilar = new Hotel("Hilton Pilar", 10000, false, true, 2);
            //     var hab1 = new Habitacion(Habitacion.BaseHab.BaseSingle, 1);
            //     hotelPilar.AgregarHabitaciones(hab1);

            //     //agrego los servicios al carrito
            //     var carritoSeis = new Carrito();
            //     carritoSeis.AgregarServicios(hotelPilar);
            //     var totalCarrito = carritoSeis.TotalCarrito();
            //     carritoSeis.MostrarCarrito();
            //     Console.WriteLine("TOTAL CARRITO 6: " + totalCarrito);
            //     Console.WriteLine("----------------------------------");
            // }
            // catch (Exception e)
            // {
            //     Console.WriteLine("Error: " + e.Message.ToString());
            // }

            // // PRUEBA 7: EXCURSION REGULAR CON MÍNIMO DE PASAJEROS
            // try
            // {
            //     var hotelFte = new Hotel("Hotel Calafate", 20000, false, 2);
            //     var habFte = new Habitacion(Habitacion.BaseHab.BaseDoble, 1);
            //     hotelFte.AgregarHabitaciones(habFte);

            //     var trfFte = new TrasladoRegular("Traslado Aeropuerto a Hotel", false, 1000, 2, 2);

            //     var excFte = new ExcursionRegular("Estancia Nibepo Aike", 7500, false, 2, 4); // esta excursión tiene un mínimo de 4 pasajeros para que salga

            //     var carritoCalafate = new Carrito();
            //     carritoCalafate.AgregarServicios(hotelFte);
            //     carritoCalafate.AgregarServicios(trfFte);
            //     carritoCalafate.AgregarServicios(excFte);
            //     var totalCarritoFte = carritoCalafate.TotalCarrito();
            //     carritoCalafate.MostrarCarrito();
            //     Console.WriteLine("TOTAL CARRITO 7: " + totalCarritoFte);
            //     Console.WriteLine("----------------------------------");
            // }
            // catch (Exception e)
            // {
            //     Console.WriteLine("Error: " + e.Message.ToString());
            // }

            // // PRUEBA 8: EXCURSIÓN PRIVADA DONDE LA CANTIDAD DE PASAJEROS ES MAYOR QUE LA CAPACIDAD DEL VEHÍCULO
            // try
            // {
            //     // Agrego una excursión donde la capacidad del vehículo contratado es menor que la cantidad de pasajeros que la quieren realizar
            //     var excursionSalinas = new ExcursionPrivada("Salinas grandes en 4x4", 3200, false, 5, 4);

            //     var carrito = new Carrito();
            //     carrito.AgregarServicios(excursionSalinas);
            //     var totalCarrito = carrito.TotalCarrito();
            //     carrito.MostrarCarrito();
            //     Console.WriteLine("TOTAL CARRITO 8: " + totalCarrito);
            //     Console.WriteLine("----------------------------------");
            // }
            // catch (Exception ex)
            // {
            //     Console.WriteLine("Error: " + ex.Message.ToString());
            // }

            // // PRUEBA 9: PAQUETE NORTE ARGENTINO
            // try
            // {
            //     var hotelSalta = new Hotel("Inkai", 10000, false, 4);
            //     var habSalta = new Habitacion(Habitacion.BaseHab.BaseDoble, 1);
            //     hotelSalta.AgregarHabitaciones(habSalta);

            //     var trasladosSalta = new TrasladoRegular("Traslado Aeropuerto a Hotel SIB", false, 1000, 2, 2);
            //     var excursionHornocal = new ExcursionPrivada("Hornocal en 4x4", 3200, false, 2, 4);
            //     var excursionQuebrada = new ExcursionRegular("Quebrada de Humahuaca SIB", 2000, false, 2, 0);

            //     var carritoNueve = new Carrito();
            //     carritoNueve.AgregarServicios(hotelSalta);
            //     carritoNueve.AgregarServicios(trasladosSalta);
            //     carritoNueve.AgregarServicios(excursionHornocal);
            //     carritoNueve.AgregarServicios(excursionQuebrada);
            //     var totalCarritoNueve = carritoNueve.TotalCarrito();
            //     carritoNueve.MostrarCarrito();
            //     Console.WriteLine("TOTAL CARRITO 9: " + totalCarritoNueve);
            //     Console.WriteLine("----------------------------------");
            // }
            // catch (Exception ex)
            // {
            //     Console.WriteLine("Error: " + ex.Message.ToString());
            // }

            // FINAL
            var bllHotel = new BLLHotel();

            // AGREGO HOTEL 1
            var hotel1 = new Hotel("IGR001","Hotel O2 Iguazú", 20000, false, 3);
            var hab1 = new Habitacion(Habitacion.BaseHab.BaseSingle, 1);
            var hab2 = new Habitacion(Habitacion.BaseHab.BaseSingle, 1);
            hotel1.AgregarHabitaciones(hab1);
            hotel1.AgregarHabitaciones(hab2);
            bllHotel.Insertar(hotel1);

            //bllHotel.Actualizar(new Hotel("IGR001","Hotel O2 Iguazú", 20000, false, 3){NombreServicio = "O2 Iguazú"});
            //bllHotel.Eliminar(hotel1);

            // HOTEL 2
            var hotel2 = new Hotel("USH001","Albatros", 10000, true, true, 4);
            var hab3 = new Habitacion(Habitacion.BaseHab.BaseDoble, 1);
            hotel2.AgregarHabitaciones(hab3);
            bllHotel.Insertar(hotel2);
            //bllHotel.Eliminar(hotel2);

            // HOTEL 3
            var hotel3 = new Hotel("BUE001","Loi Suites Recoleta", 100000, true, true, 4);
            var hab4 = new Habitacion(Habitacion.BaseHab.BaseDoble, 1);
            hotel3.AgregarHabitaciones(hab4);
            bllHotel.Insertar(hotel3);
            //bllHotel.Actualizar(new Hotel("BUE001","Loi Suites Recoleta", 100000, true, true, 4){IVAExento = false});
            //bllHotel.Eliminar(hotel3);

            // HOTEL 4
            var hotel4 = new Hotel("USH002","Los Cauquenes", 10000, true, true, 4);
            var hab5 = new Habitacion(Habitacion.BaseHab.BaseDoble, 1);
            hotel4.AgregarHabitaciones(hab5);
            bllHotel.Insertar(hotel4);
            //bllHotel.Eliminar(hotel4);

            //Mostrar todos los hoteles
            // var listaHoteles = bllHotel.Listar();
            // foreach (Hotel hotel in listaHoteles)
            // {
            //     Console.WriteLine(hotel.NombreServicio);
            // }

            // Mostrar hoteles IVA Exento
            // var listaHotelesUSH = bllHotel.HotelesIVAExento();
            // Console.WriteLine("Hoteles de Ushuaia: ");
            // foreach (Hotel hotel in listaHotelesUSH)
            // {
            //     Console.WriteLine(hotel.NombreServicio);
            // }

            // Mostrar hotel por ID
            // var hotelID = bllHotel.MostrarUnHotel("IGR001");
            // Console.WriteLine("Nombre del hotel: " + hotelID.NombreServicio);
            // Console.WriteLine("Cantidad Noches: " + hotelID.CantNoches);

            // var hotelID2 = bllHotel.MostrarUnHotel("BUE001");
            // Console.WriteLine("Nombre del hotel: " + hotelID2.NombreServicio);
            // Console.WriteLine("Cantidad Noches: " + hotelID2.CantNoches);
        }
    }
}