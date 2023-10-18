namespace PuntoDeVenta
{
    public interface ICalculadoraDescuento
    {
        double CalcularDescuento(double monto);
    }

    public class DescuentoNormal : ICalculadoraDescuento
    {
        public double CalcularDescuento(double monto)
        {
            return monto;
        }
    }

    public class DescuentoPorcentaje : ICalculadoraDescuento
    {
        private double _porcentajeDescuento;

        public DescuentoPorcentaje(double porcentajeDescuento)
        {
            _porcentajeDescuento = porcentajeDescuento;
        }

        public double CalcularDescuento(double monto)
        {
            return monto * (1 - _porcentajeDescuento / 100);
        }
    }

}
