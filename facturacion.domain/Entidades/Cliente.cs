namespace facturacion.domain.Entidades
{
    public class Cliente
    {
        public int Id { get; set; }
        public string RazonSocial { get; set; } = string.Empty;
        public TipoCliente TipoCliente { get; set; }
        public DateTime FechaCreacion { get; set; }
        public string RFC { get; set; } = string.Empty;

    }
}
