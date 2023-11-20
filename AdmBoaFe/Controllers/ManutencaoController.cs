using AdmBoaFe.App.Data.Entities;
using AdmBoaFe.App.Interface.Service;
using AdmBoaFe.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AdmBoaFe.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ManutencaoController : ControllerBase
    {
        private readonly IManutencaoService _service;
        public ManutencaoController(IManutencaoService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<IActionResult> GetAsync()
        {
            var result = await _service.ConsultarManutencoes();
            return Ok(result);
        }

        [HttpGet]
        [Route("get-manutencao-id")]
        public async Task<IActionResult> GetManutencaoByIdAsync(int idChave)
        {
            var result = await _service.ConsultarManutencaoPorId(idChave);
            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> InserirManutencao(Manutencao item)
        {
            _service.InserirManutencao(item);
            return Created($"/get-manutencao-id?id={item.Id_Manutencao}", item);
        }

        [HttpPut]
        public async Task<IActionResult> AtualizarManutencao(Manutencao item)
        {
            _service.AtualizarManutencao(item);
            return NoContent();
        }

        [Route("{idChave}")]
        [HttpDelete]
        public async Task<IActionResult> DeletarManutencao(int idChave)
        {
            _service.DeletarManutencao(idChave);
            return NoContent();
        }
    }
}
