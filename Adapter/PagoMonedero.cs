namespace Adapter
{
    public class PagoMonedero
    {

        internal void ProcesarPago()
        {
            Console.WriteLine($"Pago realizado con monedero electrónico.");
        }
    }

    public class AdaptadorMonedero : IPago
    {
        private PagoMonedero _pagoConMonedero;

        public AdaptadorMonedero(PagoMonedero pagoConMonedero)
        {
            _pagoConMonedero = pagoConMonedero;
        }

        public void Cobrar()
        {
            _pagoConMonedero.ProcesarPago();
        }
    }

}
