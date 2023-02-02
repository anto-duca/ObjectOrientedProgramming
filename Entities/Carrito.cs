using System.Collections.Generic;
using System.Linq;
using System;

namespace Entities
{
    public class Carrito
    {
        public Carrito(){
            Servicios =  new List<IServicioTuristico>();
        }
        private List<IServicioTuristico> Servicios;
        private double Total;
        private double Subtotal;
        public void AgregarServicios(IServicioTuristico servicio){
            Servicios.Add(servicio);
        }
        public double TotalCarrito(){
            // Calculo de las tarifas de los servicios
            Subtotal = Servicios.Sum(x => x.CalcularSubTotal());
            //Calculo de los impuestos de los servicios turisticos
            Impuesto.IVA = 0; // seteo el impuesto IVA en cero porque si no me va acumulando el IVA en todas las pruebas del programa
            foreach (var serv in Servicios)
            {   
                if (serv.IVAExento)
                {
                    Impuesto.IVA = 0;
                } else {
                    if (serv is Alojamiento) 
                        Impuesto.IVA += Impuesto.CalcularIVA21(serv.CalcularSubTotal());
                    else if(serv is Traslado){
                        Impuesto.IVA += Impuesto.CalcularIVA10(serv.CalcularSubTotal());   
                    }
                    else if(serv.GetType() == typeof(ExcursionPrivada)){
                        ((ExcursionPrivada)serv).ChequeoBase();
                        Impuesto.IVA += Impuesto.CalcularIVA10(serv.CalcularSubTotal());   
                    }
                    else if(serv.GetType() == typeof(ExcursionRegular)){
                        ((ExcursionRegular)serv).ChequeoMinimoPasajeros();
                        Impuesto.IVA += Impuesto.CalcularIVA10(serv.CalcularSubTotal());  
                    }
                }
            }
            Total = Subtotal + Impuesto.IVA; 
            return Total;
        }
        public void MostrarCarrito(){
            foreach (var serv in Servicios)
            {
                Console.WriteLine("SERVICIO: " + serv.NombreServicio); 
                
                if (serv.GetType() == typeof(Lodge)) 
                    Console.WriteLine("Paquete: "+((Lodge)serv).PaqueteLodge); 
                else if (serv is Hotel){
                    Console.WriteLine("Cantidad de Habitaciones: " + ((Hotel)serv).TotalHab);
                    Console.WriteLine("Cantidad de Noches: " + ((Hotel)serv).CantNoches);
                }
                else if (serv is Traslado)
                    Console.WriteLine("Traslado: " + ((Traslado)serv).GetType().ToString());  
                else if (serv is Excursion)
                    Console.WriteLine("Excursion: " + ((Excursion)serv).GetType().ToString());                  
                Console.WriteLine("SUBTOTAL: $ " + serv.CalcularSubTotal());             
            }
            Console.WriteLine("IMPUESTOS: $ " + Impuesto.IVA);
        }
    }
}