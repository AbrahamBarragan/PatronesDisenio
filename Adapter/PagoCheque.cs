namespace Adapter
{
    public class PagoConCheque
    {
        public void ProcesarPagoConCheque()
        {
            Console.WriteLine($"Pago con cheque procesado correctamente.");
        }
    }

    public class PagoCheque : IPago
    {
        private PagoConCheque _pagoConCheque;

        public PagoCheque(PagoConCheque pagoConCheque)
        {
            _pagoConCheque = pagoConCheque;
        }

        public void Cobrar()
        {
            _pagoConCheque.ProcesarPagoConCheque();
        }
    }
}
