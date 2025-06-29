namespace EspacioCalculadora
{
    public enum TipoOperacion
    {
        Suma,
        Resta,
        Multiplicacion,
        Division,
        Limpiar
     }
    public class Operacion
    {
        private double resultadoAnterior;
        private TipoOperacion tipo_operacion;
        private double nuevoValor;

        public TipoOperacion Tipo_operacion
        {
            get { return tipo_operacion; }
            set { tipo_operacion = value; }
        }
        public Operacion(double resultadoAnterior, TipoOperacion tipo_operacion, double nuevoValor)
        {
            this.resultadoAnterior = resultadoAnterior;
            this.nuevoValor = nuevoValor;
            this.tipo_operacion = tipo_operacion;
         }
        public double NuevoValor
        {
            get { return nuevoValor; }
            set { nuevoValor = value; }
        }
        public double ResultadoAnterior
        {
            get { return resultadoAnterior; }
         }
            
        public double Resultado
        {
            get
            {
                switch (Tipo_operacion)
                {
                    case TipoOperacion.Suma: return resultadoAnterior + nuevoValor;
                    case TipoOperacion.Resta: return resultadoAnterior - nuevoValor;
                    case TipoOperacion.Multiplicacion: return resultadoAnterior * nuevoValor;
                    case TipoOperacion.Division: return resultadoAnterior / nuevoValor;
                    case TipoOperacion.Limpiar: return 0;
                    default: return 0;
                }

            }
        }
        

    }
}
    