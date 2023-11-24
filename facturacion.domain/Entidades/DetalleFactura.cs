namespace facturacion.domain.Entidades
{
    public class DetalleFactura
    {
        public int Id { get; set; }
        public Producto Producto { get; set; }
        public int Cantidad { get; set; }
        public decimal PrecioUnitario { get; set; }
        public decimal Subtotal { get; set; }
        public string Notas { get; set; }

        // Métodos de dominio para calcular subtotal, etc.
    }
}
