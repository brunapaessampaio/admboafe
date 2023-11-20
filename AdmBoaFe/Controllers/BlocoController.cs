using AdmBoaFe.App.Data.Entities;
using AdmBoaFe.App.Interface.Service;
using AdmBoaFe.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AdmBoaFe.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BlocoController : ControllerBase
    {
        private readonly IBlocoService _blocoService;
        public BlocoController(IBlocoService blocoService)
        {
            _blocoService = blocoService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAsync()
        {
            var blocos = await _blocoService.ConsultarBlocos();
            return Ok(blocos);
        }

        [HttpGet]
        [Route("get-bloco-id")]
        public async Task<IActionResult> GetBlocoByIdAsync(int idBloco)
        {
            var bloco = await _blocoService.ConsultarBlocoPorId(idBloco);
            return Ok(bloco);
        }

        [HttpPost]
        public async Task<IActionResult> InserirBloco(Bloco bloco)
        {
            _blocoService.InserirBloco(bloco);
            return Created($"/get-bloco-id?id={bloco.Id_Bloco}", bloco);
        }

        [HttpPut]
        public async Task<IActionResult> AtualizarBloco(Bloco bloco)
        {
            _blocoService.AtualizarBloco(bloco);
            return NoContent();
        }

        [Route("{idChave}")]
        [HttpDelete]
        public async Task<IActionResult> DeletarBloco(int idChave)
        {
            _blocoService.DeletarBloco(idChave);
            return NoContent();
        }
    }
}
