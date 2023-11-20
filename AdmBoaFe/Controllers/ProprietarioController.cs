using AdmBoaFe.App.Data.Entities;
using AdmBoaFe.App.Interface.Service;
using AdmBoaFe.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AdmBoaFe.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProprietarioController : ControllerBase
    {
        private readonly IProprietarioService _service;
        public ProprietarioController(IProprietarioService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<IActionResult> GetAsync()
        {
            var result = await _service.ConsultarProprietarios();
            return Ok(result);
        }

        [HttpGet]
        [Route("get-locatario-id")]
        public async Task<IActionResult> GetProprietarioByIdAsync(int idChave)
        {
            var result = await _service.ConsultarProprietarioPorId(idChave);
            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> InserirProprietario(Proprietario item)
        {
            _service.InserirProprietario(item);
            return Created($"/get-proprietario-id?id={item.Id_Proprietario}", item);
        }

        [HttpPut]
        public async Task<IActionResult> AtualizarProprietario(Proprietario item)
        {
            _service.AtualizarProprietario(item);
            return NoContent();
        }

        [Route("{idChave}")]
        [HttpDelete]
        public async Task<IActionResult> DeletarProprietario(int idChave)
        {
            _service.DeletarProprietario(idChave);
            return NoContent();
        }
    }
}
