namespace Strategy
{
    public class ProductoDescuentoVIP : IProductoDescuentoStrategy
    {
        public decimal ClacularDescuento(decimal precio)
        {
            return precio * 0.20m;
        }
    }
}
