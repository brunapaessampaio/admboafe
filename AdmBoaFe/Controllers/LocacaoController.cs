using AdmBoaFe.App.Data.Entities;
using AdmBoaFe.App.Interface.Service;
using AdmBoaFe.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AdmBoaFe.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class LocacaoController : ControllerBase
    {
        private readonly ILocacaoService _service;
        public LocacaoController(ILocacaoService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<IActionResult> GetAsync()
        {
            var result = await _service.ConsultarLocacoes();
            return Ok(result);
        }

        [HttpGet]
        [Route("get-locacao-id")]
        public async Task<IActionResult> GetLocacaoByIdAsync(int idChave)
        {
            var result = await _service.ConsultarLocacaoPorId(idChave);
            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> InserirLocacao(Locacao item)
        {
            _service.InserirLocacao(item);
            return Created($"/get-locacao-id?id={item.Id_Locacao}", item);
        }

        [HttpPut]
        public async Task<IActionResult> AtualizarLocacao(Locacao item)
        {
            _service.AtualizarLocacao(item);
            return NoContent();
        }

        [Route("{id}")]
        [HttpDelete]
        public async Task<IActionResult> DeletarLocacao(int idChave)
        {
            _service.DeletarLocacao(idChave);
            return NoContent();
        }
    }
}
