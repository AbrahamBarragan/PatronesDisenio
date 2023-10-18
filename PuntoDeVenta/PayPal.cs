namespace PuntoDeVenta
{
    public class PayPal : IMetodoPago
    {
        private PayPal _payPal;

        public PayPal(PayPal payPal)
        {
            _payPal = payPal;
        }

        public void Pagar(double cantidad)
        {
            _payPal.Pagar(cantidad);
        }
    }
}
