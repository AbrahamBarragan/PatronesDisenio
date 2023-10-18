namespace Adapter
{
    internal class PagoEfectivo : IPago
    {
        public void Cobrar()
        {
            Console.WriteLine("Cobrando en efectivo");
        }
    }
}
