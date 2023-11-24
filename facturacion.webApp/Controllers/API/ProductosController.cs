using facturacion.application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace facturacion.webApp.Controllers.API
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductosController : ControllerBase
    {
        private readonly IProductoService _productoService;

        public ProductosController(IProductoService productoService)
        {
            _productoService = productoService;
        }

        [HttpGet("getAll")]
        public async Task<IActionResult> getProductos()
        {
            var productos =await _productoService.getAllAsync();
            if(productos != null)
            {
                if(productos.IsSuccess)
                {
                    return Ok(productos.data);
                }
                else
                {
                    return BadRequest(productos);
                }
            }
            else
            {
                return BadRequest("Error al consultar productos");
            }
        }
    }
}
