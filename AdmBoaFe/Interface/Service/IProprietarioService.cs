using AdmBoaFe.App.Data.DTOs;
using AdmBoaFe.App.Data.Entities;
using AdmBoaFe.Data;

namespace AdmBoaFe.App.Interface.Service
{
    public interface IProprietarioService
    {
        public Task<List<ProprietarioDTO>> ConsultarProprietarios();
        public Task<ProprietarioDTO> ConsultarProprietarioPorId(int? Id);
        //public Task<UnidadeCondominialDTO> ConsultarUnidadesPorProprietarios(int? IdProp);
        public void InserirProprietario(Proprietario prop);
        public void AtualizarProprietario(Proprietario prop);
        public void DeletarProprietario(int idProp);

    }
}
