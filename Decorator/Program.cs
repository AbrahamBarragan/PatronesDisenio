using Decorator;

List<string> productos = new List<string>()
{
    "Yuban","Pastel","Buñuelos"
};

IVenta venta =new Venta(productos);
Console.WriteLine(venta);

venta = new DescuentoDecorador(venta,10);
Console.WriteLine(venta);

venta = new CargoDecorador(venta, 50);
Console.WriteLine(venta);