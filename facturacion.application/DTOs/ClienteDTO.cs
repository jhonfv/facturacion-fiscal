namespace facturacion.application.DTOs
{
    public class ClienteDTO
    {
        public int Id { get; set; }
        public string RazonSocial { get; set; } = string.Empty;
        public string RFC { get; set; } = string.Empty;
    }
}
