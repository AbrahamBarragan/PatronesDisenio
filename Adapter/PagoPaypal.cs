namespace Adapter
{
    internal class PagoPaypal : IPago
    {
        
        private readonly string _pagoPaypal;

        public PagoPaypal(string pagoPaypal)
        {
            _pagoPaypal = pagoPaypal;
        }

        public void Cobrar()
        {
            Console.WriteLine($"Pago realizado a través de paypal");
        }
    }
}
