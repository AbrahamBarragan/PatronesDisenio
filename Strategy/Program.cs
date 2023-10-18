using Strategy;

Producto celular = new Producto(new ProductoDescuentoVIP());
celular.Descripcion = "Iphone 15";
celular.Precio = 49000m;

Console.WriteLine($"El precio de {celular.Descripcion} es: {celular.PrecioDeVenta} con un descuento de: {celular.Descuento}");