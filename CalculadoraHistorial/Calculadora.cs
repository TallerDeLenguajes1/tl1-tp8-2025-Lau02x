
using System.Collections.Generic;
namespace EspacioCalculadora
{
    public class Calculadora
    {
        private double dato;
        public double resultado = 0;
        public List<Operacion> historial
        {
            get; private set;
        }
        public Calculadora()
        {
            dato = 0;
            historial = new List<Operacion>();
         }
        public void Sumar(double termino)
        {
            historial.Add(new Operacion(dato,TipoOperacion.Suma,termino));
            dato += termino;
        }
        public void Restar(double termino)
        {
            historial.Add(new Operacion(dato,TipoOperacion.Resta,termino));
            dato -= termino;
        }
        public void Multiplicar(double termino)
        {
            historial.Add(new Operacion(dato,TipoOperacion.Multiplicacion,termino));
            dato *= termino;
        }
        public void Dividir(double termino)
        {
            if (termino != 0)
            {
                historial.Add(new Operacion(dato,TipoOperacion.Division,termino));
                dato /= termino;
            }
        }
        public void Limpiar()
        {
            historial.Add(new Operacion(dato,TipoOperacion.Limpiar,0));
            dato = 0;
        }
        public double Resultado()
        {
            return dato;
        }
     
     }
}