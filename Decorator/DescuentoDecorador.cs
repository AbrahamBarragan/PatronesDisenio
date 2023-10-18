namespace Decorator
{
    public class DescuentoDecorador : VentaDecorador
    {
        private decimal _porcentajeDescuento;
        public DescuentoDecorador(IVenta venta, decimal porcentajeDescuento)
            : base(venta)
        {
            _porcentajeDescuento = porcentajeDescuento;
        }

        public override decimal CalcularTotal()
        {
            decimal totalBase = base.CalcularTotal();
            decimal descuento = totalBase * (_porcentajeDescuento / 100);
            return totalBase - descuento;
        }
        public override string ToString()
        {
            return $"El Total de la Venta con descuento es: {CalcularTotal():N2}";
        }
    }
}
