namespace Adapter
{
    internal class PagoTarjetaCredito : IPago
    {
        private readonly string _numTarjeta;
        public PagoTarjetaCredito(string numTarjeta)
        {
            _numTarjeta = numTarjeta;
        }

        public void Cobrar()
        {
            Console.WriteLine($"Pagando con tarjeta de crédito terminación {_numTarjeta}");
        }
    }
}
