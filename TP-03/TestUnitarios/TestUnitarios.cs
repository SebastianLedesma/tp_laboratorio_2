using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Clases_Instanciables;
using EntidadesAbstractas;
using Excepciones;

namespace TestUnitarios
{
    [TestClass]
    public class TestUnitarios
    {
        [TestMethod]
        [ExpectedException(typeof(AlumnoRepetidoException))]
        //Método que probará el funcionamiento de la AlumnoRepetidoException.
        public void VerificarAlumnoRepetido()
        {
            //Arrange
            Universidad uni = new Universidad();
            Alumno alu1 = new Alumno(1, "Jose", "Perez", "36777999", Universitario.ENacionalidad.Argentino, Universidad.EClases.Laboratorio);
            Alumno alu2 = new Alumno(1, "Maria", "Perez", "36777999", Universitario.ENacionalidad.Argentino, Universidad.EClases.Programacion);

            //Act
            uni += alu1;
            uni += alu2;
        }

        [TestMethod]
        [ExpectedException(typeof(DniInvalidoException))]
        //Método que probará que ocurre cuando un dni tiene un formato no válido.
        public void VerificarDniPersona()
        {
            //Arrange
            string dniConCaracteres = "189023441";//9 caractateres
            string dniConLetras = "12r32434";//contiene caracteres no numéricos
            int dniConvertido = 0;

            //Act
            dniConvertido = Persona.ValidadDni(Universitario.ENacionalidad.Argentino,dniConLetras);
        }

        [TestMethod]
        [ExpectedException(typeof(NacionalidadInvalidaException))]
        //Método que probará que ocurre cuando el dni es válido pero la nacionalidad extranjera no se condice con este.
        public void VerificarNacionalidadPersonaExtranjera()
        {
            //Arrange
            int dniArgentino=20432344;
            int dniExtranjero = 90123244;
            int dniValido;

            //La nacionalidad no condice con el dni.Para extranjero(desde 90000000 hasta 99999999)
            dniValido = Persona.ValidadDni(Persona.ENacionalidad.Extranjero,dniArgentino);
        }

        [TestMethod]
        [ExpectedException(typeof(NacionalidadInvalidaException))]
        //Método que probará que ocurre cuando el dni es válido pero la nacionalidad argentino no se condice con este.
        public void VerificarNacionalidadPersonaAargentina()
        {
            //Arrange
            int dniExtranjero = 90123244;
            int dniValido;

            //La nacionalidad no condice con el dni.Para argentino(desde 1 hasta 89999999)
            dniValido = Persona.ValidadDni(Persona.ENacionalidad.Argentino,dniExtranjero);
        }


        [TestMethod]
        [ExpectedException(typeof(SinProfesorException))]
        //Método que probará que ocurre cuando se quiere agregar una clase a la universidad pero no hay un profesor que
        //la dicte.
        public void ValidadProfesorParaDarClase()
        {
            //Arrange
            Universidad univ = new Universidad();
            Profesor prof = new Profesor(1,"Raul","Torres","20321232",Persona.ENacionalidad.Argentino);
            Profesor profParaDarClase;

            univ += prof;//La univ tiene un profe que puede dar 2 clases.

            //Act
            profParaDarClase = univ == Universidad.EClases.Laboratorio;//El único profe que hay puede que dicte esta clase.
            profParaDarClase = univ == Universidad.EClases.Programacion;//El único profe que hay puede que dicte esta clase.

            //Si no ocurrió la exception en los anteriores es porque son justo las 2 clases que dicta el prof.
            //Aquí debería saltar la exception si o si.
            profParaDarClase = univ == Universidad.EClases.Legislacion;
        }


        [TestMethod]
        //Método que compruenba la inicialización de un atribut de tipo lista al invocar un construtor por default.
        public void ValidarInstanciacionDeAtribLista()
        {
            //Arrange
            Universidad univ = new Universidad();//creo una instancia de Universidad.Su constructor por default inicializa
            //todos sus atributos(lista de profesores,lista de alumnos y lista de jornadas).
            bool estaInstanciada;

            //Act
            estaInstanciada = univ.Alumnos != null;//Si no se instanció el atributo List<Alumnos> la comparación será false.

            //Assert
            Assert.IsTrue(estaInstanciada);//se espera un true en el parámetro.
        }

    }
}
