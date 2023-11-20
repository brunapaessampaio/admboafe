using AdmBoaFe.App.Data.DTOs;
using AdmBoaFe.App.Data.Entities;
using AdmBoaFe.Data;

namespace AdmBoaFe.App.Interface.Service
{
    public interface ILocacaoService
    {
        public Task<List<LocacaoDTO>> ConsultarLocacoes();
        public Task<LocacaoDTO> ConsultarLocacaoPorId(int? Id);
        public void InserirLocacao(Locacao loc);
        public void AtualizarLocacao(Locacao loc);
        public void DeletarLocacao(int idLocacao);

    }
}
