using AdmBoaFe.App.Data.DTOs;
using AdmBoaFe.App.Data.Entities;
using AdmBoaFe.Data;

namespace AdmBoaFe.App.Interface.Service
{
    public interface ILocatarioService
    {
        public Task<List<LocatarioDTO>> ConsultarLocatarios();
        public Task<LocatarioDTO> ConsultarLocatarioPorId(int? Id);
        public void InserirLocatario(Locatario locatario);
        public void AtualizarLocatario(Locatario locatario);
        public void DeletarLocatario(int idLocatario);

    }
}
