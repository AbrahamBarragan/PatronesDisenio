namespace PuntoDeVenta
{
    public interface IProducto
    {
        string ObtenerDescripcion();
        double ObtenerPrecio();
    }

    public class ProductoBase : IProducto
    {
        public string ObtenerDescripcion()
        {
            return "Producto básico";
        }

        public double ObtenerPrecio()
        {
            return 50.0;
        }
    }

    public class ProductoConEnvoltorio : IProducto
    {
        private IProducto _producto;

        public ProductoConEnvoltorio(IProducto producto)
        {
            _producto = producto;
        }

        public string ObtenerDescripcion()
        {
            return _producto.ObtenerDescripcion() + ", con envoltorio elegante";
        }

        public double ObtenerPrecio()
        {
            return _producto.ObtenerPrecio() + 10.0;
        }
    }

}
