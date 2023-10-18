namespace Strategy
{
    public class ProductoDescuento : IProductoDescuentoStrategy
    {
        public decimal ClacularDescuento(decimal precio)
        {
            return precio * 0.05m;
        }
    }
}
