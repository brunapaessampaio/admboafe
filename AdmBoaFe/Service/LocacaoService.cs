using AdmBoaFe.App.Data.DTOs;
using AdmBoaFe.App.Data.Entities;
using AdmBoaFe.App.Interface.Service;
using AdmBoaFe.Data;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using NuGet.Protocol.Core.Types;
using System.Collections.Generic;

namespace AdmBoaFe.App.Service
{
    public class LocacaoService: ILocacaoService
    {
        private readonly IMapper _mapper;
        private readonly AdmBoaFeDbContext _admBoaFeDbContext;
        private readonly ILocatarioService _locService;
        private readonly IUnidadeCondominialService _unidadeService;

        public LocacaoService(AdmBoaFeDbContext admBoaFeDbContext, IMapper mapper,
                               ILocatarioService locService, IUnidadeCondominialService unidadeService)
        {
            _admBoaFeDbContext = admBoaFeDbContext;
            _mapper = mapper;
            _locService = locService;
            _unidadeService = unidadeService;   
        }

        public async Task<List<LocacaoDTO>> ConsultarLocacoes()
        {
            var listAsync = await _admBoaFeDbContext.Locacao.ToListAsync();
            var lista =  _mapper.Map<List<LocacaoDTO>>(listAsync);

            foreach (var item in lista)
            {
                item.LocatarioDTO = _locService.ConsultarLocatarioPorId(item.Id_Locatario).Result;
                item.UnidadeCondominialDTO = _unidadeService.ConsultarUnidadeCondominialPorId(item.Id_Unidade_Condominal).Result;
            }

            return lista;

        }

        public async Task<LocacaoDTO> ConsultarLocacaoPorId(int? Id)
        {
            var result = await _admBoaFeDbContext.Locacao.FindAsync(Id);
            LocacaoDTO dto = new LocacaoDTO();

            if (result != null)
            { 
                dto = _mapper.Map<LocacaoDTO>(result);

                dto.LocatarioDTO = _locService.ConsultarLocatarioPorId(result.Id_Locatario).Result;
                dto.UnidadeCondominialDTO = _unidadeService.ConsultarUnidadeCondominialPorId(result.Id_Unidade_Condominal).Result;
            }
            return dto;

        }

        public void InserirLocacao(Locacao locacao)
        {
            _admBoaFeDbContext.Locacao.Add(locacao);
            _admBoaFeDbContext.SaveChanges();
        }

        public void AtualizarLocacao(Locacao locacao)
        {
            _admBoaFeDbContext.Locacao.Update(locacao);
            _admBoaFeDbContext.SaveChanges();
        }

        public void DeletarLocacao(int idLocacao)
        {
            var locDel = _admBoaFeDbContext.Locacao.Find(idLocacao);
            if (locDel != null)
            {
                _admBoaFeDbContext.Locacao.Remove(locDel);
                _admBoaFeDbContext.SaveChanges();
            }
            
        }

    }
}
