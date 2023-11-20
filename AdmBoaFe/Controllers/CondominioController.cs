using AdmBoaFe.App.Data.Entities;
using AdmBoaFe.App.Interface.Service;
using AdmBoaFe.App.Service;
using AdmBoaFe.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AdmBoaFe.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CondominioController : ControllerBase
    {
        private readonly ICondominioService _condService;
        public CondominioController(ICondominioService condService)
        {
            _condService = condService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAsync()
        {
            var cond = await _condService.ConsultarCondominios();
            return Ok(cond);
        }

        [HttpGet]
        [Route("get-condominio-by-id")]
        public async Task<IActionResult> GetCondominioByIdAsync(int id)
        {
            var cond = await _condService.ConsultarCondominioPorId(id);
            return Ok(cond);
        }

        [HttpPost]
        public async Task<IActionResult> InserirCondominio(Condominio cond)
        {
            _condService.InserirCondominio(cond);
            return Created($"/get-condominio-by-id?id={cond.Id_Condominio}", cond);
        }

        [HttpPut]
        public async Task<IActionResult> AtualizarCondominio(Condominio cond)
        {
            _condService.AtualizarCondominio(cond);
            return NoContent();
        }

        [Route("{id}")]
        [HttpDelete]
        public async Task<IActionResult> DeletarCondominio(int idBloco)
        {
            _condService.DeletarCondominio(idBloco);
            return NoContent();
        }
    }
}
