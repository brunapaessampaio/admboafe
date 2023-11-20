using AdmBoaFe.App.Data.Entities;
using AdmBoaFe.App.Interface.Service;
using AdmBoaFe.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AdmBoaFe.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class LocatarioController : ControllerBase
    {
        private readonly ILocatarioService _service;
        public LocatarioController(ILocatarioService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<IActionResult> GetAsync()
        {
            var result = await _service.ConsultarLocatarios();
            return Ok(result);
        }

        [HttpGet]
        [Route("get-locatario-id")]
        public async Task<IActionResult> GetLocatarioByIdAsync(int idChave)
        {
            var result = await _service.ConsultarLocatarioPorId(idChave);
            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> InserirLocatario(Locatario item)
        {
            _service.InserirLocatario(item);
            return Created($"/get-locatario-id?id={item.Id_Locatario}", item);
        }

        [HttpPut]
        public async Task<IActionResult> AtualizarLocatario(Locatario item)
        {
            _service.AtualizarLocatario(item);
            return NoContent();
        }

        [Route("{idChave}")]
        [HttpDelete]
        public async Task<IActionResult> DeletarLocatario(int idChave)
        {
            _service.DeletarLocatario(idChave);
            return NoContent();
        }
    }
}
