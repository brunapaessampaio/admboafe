using AdmBoaFe.App.Data.DTOs;
using AdmBoaFe.App.Data.Entities;

namespace AdmBoaFe.App.Interface.Service
{
    public interface ICondominioService
    {
        public Task<List<CondominioDTO>> ConsultarCondominios();
        public Task<CondominioDTO> ConsultarCondominioPorId(int? Id);
        public void InserirCondominio(Condominio cond);
        public void AtualizarCondominio(Condominio cond);
        public void DeletarCondominio(int idCondominio);
    }
}
