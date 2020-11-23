using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Excepciones;

namespace TestConsola
{
    class Program
    {
        static void Main(string[] args)
        {
            Deposito deposito = new Deposito(2, 2, 2, 2);

            Martillo mart = new Martillo(Herramienta.EDistribuidor.HerramientasArgentinas,
                                         120, 
                                         Herramienta.EOrigen.Brasil,
                                         Martillo.ETipoMartillo.Maza,
                                         Martillo.ETipoDeMango.Plastico);

            Taladro taladro = new Taladro(Herramienta.EDistribuidor.ElReyDeLasHerramientas,
                                            210,
                                            Herramienta.EOrigen.Argentina,
                                            Taladro.EPesoGramos.Trescientos,
                                            Taladro.ETiempoTrabajo.UnaHora);

            CintaMetrica cinta = new CintaMetrica(Herramienta.EDistribuidor.HerramientasCongreso,
                                                    53,
                                                    Herramienta.EOrigen.Paraguay,
                                                    CintaMetrica.ELargoCintaMts.Tres,
                                                    CintaMetrica.EMaterial.AceroInoxidable);

            Escalera escalera = new Escalera(Herramienta.EDistribuidor.HerramientasArgentinas,
                                            200,
                                            Herramienta.EOrigen.Brasil,
                                            Escalera.ETamaño.Grande,
                                            Escalera.EMaterial.Madera);

            CarritoCompra<Herramienta> carrito = new CarritoCompra<Herramienta>(3);
            Factura fact;

            try
            {
                carrito += mart;
                Console.WriteLine("Herramienta agregada.");
            }
            catch (CarritoLlenoException ex)
            {
                Console.WriteLine(ex.Message);
            }

            try
            {
                carrito += taladro;
                Console.WriteLine("Herramienta agregada.");
            }
            catch (CarritoLlenoException ex)
            {
                Console.WriteLine(ex.Message);
            }

            try
            {
                carrito += cinta;
                Console.WriteLine("Herramienta agregada.");
            }
            catch (CarritoLlenoException ex)
            {
                Console.WriteLine(ex.Message);
            }

            try
            {
                carrito += escalera;
                Console.WriteLine("Herramienta agregada.");
            }
            catch (CarritoLlenoException ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.WriteLine(carrito.ToString());

            fact = new Factura(carrito.PrecioCarro,Factura.EMedioPago.Debito);
            Console.WriteLine(fact.ToString());

            Console.ReadKey();
        }
    }
}
