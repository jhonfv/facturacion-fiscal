namespace facturacion.domain.Entidades
{
    public class Factura
    {
        public int Id { get;  set; }
        public DateTime FechaEmision { get;  set; }
        public int NumeroFactura { get;  set; }
        public int NumeroTotalArticulos { get;  set; }
        public decimal SubTotal { get;  set; }
        public decimal TotalImpuesto { get;  set; }
        public decimal Total { get;  set; }
        public Cliente Cliente { get;  set; }
        public IList<DetalleFactura> DetallesFactura { get;  set; } = new List<DetalleFactura>();
    }
}
