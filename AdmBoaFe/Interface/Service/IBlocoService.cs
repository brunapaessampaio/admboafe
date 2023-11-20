using AdmBoaFe.App.Data.DTOs;
using AdmBoaFe.App.Data.Entities;
using AdmBoaFe.Data;

namespace AdmBoaFe.App.Interface.Service
{
    public interface IBlocoService
    {
        public Task<List<BlocoDTO>> ConsultarBlocos();
        public Task<BlocoDTO> ConsultarBlocoPorId(int? Id);
        public void InserirBloco(Bloco bloco);
        public void AtualizarBloco(Bloco bloco);
        public void DeletarBloco(int idBloco);

    }
}
