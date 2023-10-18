namespace PuntoDeVenta
{
    internal class TarjetaCredito : IMetodoPago
    {
        private TarjetaCredito _pagoConTarjeta;
        private readonly string _numTarjeta;

        public TarjetaCredito(string numTarjeta)
        {
            _numTarjeta = numTarjeta;
        }

        public TarjetaCredito(TarjetaCredito pagoConTarjeta)
        {
            _pagoConTarjeta = pagoConTarjeta;
        }

        public void Pagar(double cantidad)
        {
            _pagoConTarjeta.RealizarPagoConTarjeta(cantidad);
        }

        public void RealizarPagoConTarjeta(double monto)
        {

            Console.WriteLine($"Pagando {monto} con tarjeta de crédito terminación {_numTarjeta}");
        }
    }
}
