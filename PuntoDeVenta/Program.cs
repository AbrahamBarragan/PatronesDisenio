using PuntoDeVenta;

class Program
{
    static void Main(string[] args)
    {
        
        IMetodoPago metodoPagoTarjeta = new PagoConTarjeta();
        IMetodoPago metodoPagoEfectivo = new AdaptadorPagoEnEfectivo(new PagoEnEfectivo());

        
        IProducto productoBasico = new ProductoBase();
        IProducto productoConEnvoltorio = new ProductoConEnvoltorio(productoBasico);

        
        ICalculadoraDescuento calculadoraDescuentoNormal = new DescuentoNormal();
        ICalculadoraDescuento calculadoraDescuentoPorcentaje = new DescuentoPorcentaje(10);

        
        double totalVenta1 = CalcularTotalVenta(productoBasico, metodoPagoTarjeta, calculadoraDescuentoNormal);
        double totalVenta2 = CalcularTotalVenta(productoConEnvoltorio, metodoPagoEfectivo, calculadoraDescuentoPorcentaje);

        Console.WriteLine($"Total de venta 1: {totalVenta1}");
        Console.WriteLine($"Total de venta 2: {totalVenta2}");

        Console.ReadKey();
    }

    static double CalcularTotalVenta(IProducto producto, IMetodoPago metodoPago, ICalculadoraDescuento calculadoraDescuento)
    {
        double precioProducto = producto.ObtenerPrecio();
        double descuento = calculadoraDescuento.CalcularDescuento(precioProducto);
        double total = descuento;

        Console.WriteLine($"Producto: {producto.ObtenerDescripcion()}");
        Console.WriteLine($"Precio original: {precioProducto}");
        Console.WriteLine($"Descuento aplicado: {descuento}");

        metodoPago.ProcesarPago(total);
        return total;
    }
}
