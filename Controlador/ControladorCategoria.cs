using Microsoft.AspNetCore.Mvc;

namespace ControleEstoque.WebAPI.Controlador
{
    public class ControladorCategoria : ControllerBase
    {
        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok();
        }
    }
}
