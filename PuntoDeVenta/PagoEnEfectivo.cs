namespace PuntoDeVenta
{
    public class PagoEnEfectivo
    {
        public void RealizarPagoEnEfectivo(double monto)
        {
            Console.WriteLine($"Pago en efectivo por {monto}.");
        }
    }

    public class AdaptadorPagoEnEfectivo : IMetodoPago
    {
        private PagoEnEfectivo _pagoEnEfectivo;

        public AdaptadorPagoEnEfectivo(PagoEnEfectivo pagoEnEfectivo)
        {
            _pagoEnEfectivo = pagoEnEfectivo;
        }

        public void ProcesarPago(double monto)
        {
            _pagoEnEfectivo.RealizarPagoEnEfectivo(monto);
        }
    }

}
