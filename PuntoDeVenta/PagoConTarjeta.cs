namespace PuntoDeVenta
{
    public class PagoConTarjeta : IMetodoPago
    {
        public void ProcesarPago(double monto)
        {
            Console.WriteLine($"Pago con tarjeta por {monto}.");
        }
    }

}
