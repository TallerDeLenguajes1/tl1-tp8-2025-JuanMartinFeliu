using System.Collections.Generic;

namespace CALCULADORA
{
    public class Calculadora
    {
        private double resultadoActual = 0;
        private List<Operacion> historial = new List<Operacion>();

        public double ResultadoActual => resultadoActual;

        public void AplicarOperacion(double valor, TipoOperacion tipo)
        {
            if (tipo == TipoOperacion.Limpiar)
            {
                resultadoActual = 0;
                historial.Clear();
            }
            else
            {
                Operacion op = new Operacion(resultadoActual, valor, tipo);
                resultadoActual = op.Resultado;
                historial.Add(op);
            }
        }

        public List<Operacion> ObtenerHistorial()
        {
            return historial;
        }
    }
}
