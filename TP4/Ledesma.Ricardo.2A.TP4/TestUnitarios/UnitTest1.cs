using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Entidades;
using Excepciones;

namespace TestUnitarios
{
    [TestClass]
    public class UnitTest1
    {
        //Método que valida que se lanza la CarritoLlenoException al intentar superar la capacidad del carrito.
        [TestMethod]
        [ExpectedException(typeof(CarritoLlenoException))]
        public void ValidarCarritoLleno()
        {
            CarritoCompra<Herramienta> carrito = new CarritoCompra<Herramienta>(1);//solo admite una herramienta.
            carrito += new Martillo(Martillo.EDistribuidor.ElReyDeLasHerramientas,
                                    120,
                                    Martillo.EOrigen.Brasil,
                                    Martillo.ETipoMartillo.Maza,
                                    Martillo.ETipoDeMango.Madera);

            carrito+=new Martillo(Martillo.EDistribuidor.HerramientasArgentinas,
                                    120,
                                    Martillo.EOrigen.Argentina,
                                    Martillo.ETipoMartillo.Maza,
                                    Martillo.ETipoDeMango.Plastico);
        }


        //Método que verifica el funcionamiento de la propiedad PrecioCarro la cual recorre la lista del carrito y acumula
        //sus precios.
        [TestMethod]
        public void VerificarAcumulacionPrecioCarrito()
        {
            CarritoCompra<Herramienta> carrito = new CarritoCompra<Herramienta>(2);
            carrito += new Martillo(Martillo.EDistribuidor.ElReyDeLasHerramientas,
                                    90,
                                    Martillo.EOrigen.Brasil,
                                    Martillo.ETipoMartillo.Maza,
                                    Martillo.ETipoDeMango.Madera);

            carrito += new Martillo(Martillo.EDistribuidor.HerramientasArgentinas,
                                    120,
                                    Martillo.EOrigen.Argentina,
                                    Martillo.ETipoMartillo.Maza,
                                    Martillo.ETipoDeMango.Plastico);

            bool respuesta = carrito.PrecioCarro > 209;//se espera que al haber 2 productos en el carrito la propiedad devuelva
            //210 que es el acumulado de precios,al compararlo con un su nro anterior se verifica si se realizó la acumulación.

            Assert.IsTrue(respuesta);
        }
    }
}
