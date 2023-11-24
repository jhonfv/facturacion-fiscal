namespace facturacion.application.DTOs
{
    public class ProductoDTO
    {
        public int Id { get; set; }
        public string NombreProducto { get; set; } = string.Empty;
        public decimal PrecioUnitario { get; set; }
        public byte[] ImagenProducto { get; set; } = new byte[0];
    }
}
