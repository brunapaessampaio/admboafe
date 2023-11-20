using AdmBoaFe.App.Data.Entities;
using AdmBoaFe.App.Interface.Service;
using AdmBoaFe.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AdmBoaFe.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UnidadeCondominialController : ControllerBase
    {
        private readonly IUnidadeCondominialService _service;
        public UnidadeCondominialController(IUnidadeCondominialService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<IActionResult> GetAsync()
        {
            var result = await _service.ConsultarUnidadesCondominiais();
            return Ok(result);
        }

        [HttpGet]
        [Route("get-unidade-id")]
        public async Task<IActionResult> GetUnidadeCondominialByIdAsync(int idChave)
        {
            var result = await _service.ConsultarUnidadeCondominialPorId(idChave);
            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> InserirUnidadeCondominial(UnidadeCondominial item)
        {
            _service.InserirUnidadeCondominial(item);
            return Created($"/get-unidade-id?id={item.Id_Unidade}", item);
        }

        [HttpPut]
        public async Task<IActionResult> AtualizarUnidadeCondominial(UnidadeCondominial item)
        {
            _service.AtualizarUnidadeCondominial(item);
            return NoContent();
        }

        [Route("{idChave}")]
        [HttpDelete]
        public async Task<IActionResult> DeletarUnidadeCondominial(int idChave)
        {
            _service.DeletarUnidadeCondominial(idChave);
            return NoContent();
        }
    }
}
