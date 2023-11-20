using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces
{
    public interface IBlocoService
    {
        Task<ControleIntegracaoDTO> ConsultarIntegracao(ControleIntegracaoPesquisaDTO integracao);
        Task<ControleIntegracaoDTO> RealizarIntegracao(ControleIntegracaoPesquisaDTO integracao);
    }
}
