namespace PuntoDeVenta
{
    internal class Ventas
    {
        private readonly IMetodoPago _pago;

        public Ventas(IMetodoPago pago)
        {
            _pago = pago;
        }

        public void ProcesarPago()
        {
            _pago.Pagar();
        }

    }
}
