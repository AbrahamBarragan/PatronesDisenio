namespace Adapter
{
    internal class PagoTarjetaDebito : IPago
    {
        private readonly string _numTarjeta;
        public PagoTarjetaDebito(string numTarjeta)
        {
            _numTarjeta = numTarjeta;
        }
        public void Cobrar()
        {
            Console.WriteLine($"Pagado con tarjeta de debito terminacion {_numTarjeta}");
        }
    }
}
