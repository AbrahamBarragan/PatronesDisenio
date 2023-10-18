namespace Adapter
{
    internal class PagoTransferencia : IPago
    {
        public void Cobrar()
        {
            Console.WriteLine("Cobrando por transferencia");
        }
    }
}
