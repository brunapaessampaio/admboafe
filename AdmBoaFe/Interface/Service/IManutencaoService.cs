using AdmBoaFe.App.Data.DTOs;
using AdmBoaFe.App.Data.Entities;
using AdmBoaFe.Data;

namespace AdmBoaFe.App.Interface.Service
{
    public interface IManutencaoService
    {
        public Task<List<ManutencaoDTO>> ConsultarManutencoes();
        public Task<ManutencaoDTO> ConsultarManutencaoPorId(int Id);
        public void InserirManutencao(Manutencao manut);
        public void AtualizarManutencao(Manutencao manut);
        public void DeletarManutencao(int idManut);

    }
}
