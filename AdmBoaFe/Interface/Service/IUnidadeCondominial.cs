using AdmBoaFe.App.Data.DTOs;
using AdmBoaFe.App.Data.Entities;
using AdmBoaFe.Data;

namespace AdmBoaFe.App.Interface.Service
{
    public interface IUnidadeCondominialService
    {
        public Task<List<UnidadeCondominialDTO>> ConsultarUnidadesCondominiais();
        public Task<UnidadeCondominialDTO> ConsultarUnidadeCondominialPorId(int? Id);
        public void InserirUnidadeCondominial(UnidadeCondominial unidade);
        public void AtualizarUnidadeCondominial(UnidadeCondominial unidade);
        public void DeletarUnidadeCondominial(int idUnidade);

    }
}
