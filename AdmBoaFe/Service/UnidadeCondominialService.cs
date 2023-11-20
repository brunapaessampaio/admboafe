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
    public class UnidadeCondominialService : IUnidadeCondominialService
    {
        private readonly IMapper _mapper;
        private readonly AdmBoaFeDbContext _admBoaFeDbContext;
        private readonly IBlocoService _blocoService;

        public UnidadeCondominialService(AdmBoaFeDbContext admBoaFeDbContext, IMapper mapper, IBlocoService blocoService)
        {
            _admBoaFeDbContext = admBoaFeDbContext;
            _mapper = mapper;
            _blocoService = blocoService;
        }

        public async Task<List<UnidadeCondominialDTO>> ConsultarUnidadesCondominiais()
        {
            var result = await _admBoaFeDbContext.UnidadeCondominial.ToListAsync();
            var lista =  _mapper.Map<List<UnidadeCondominialDTO>>(result);

            foreach (var item in lista)
            {
                item.BlocoDTO = _blocoService.ConsultarBlocoPorId(item.Id_Bloco).Result;
            }

            return lista;

        }

        public async Task<UnidadeCondominialDTO> ConsultarUnidadeCondominialPorId(int? Id)
        {
            var result = await _admBoaFeDbContext.UnidadeCondominial.FindAsync(Id);
            UnidadeCondominialDTO dto = new UnidadeCondominialDTO();
            
            if (result != null)
            {
               dto = _mapper.Map<UnidadeCondominialDTO>(result);
               dto.BlocoDTO = _blocoService.ConsultarBlocoPorId(dto.Id_Bloco).Result;
            }

            return dto;

        }

        public void InserirUnidadeCondominial(UnidadeCondominial unidade)
        {
            _admBoaFeDbContext.UnidadeCondominial.Add(unidade);
            _admBoaFeDbContext.SaveChanges();
        }

        public void AtualizarUnidadeCondominial(UnidadeCondominial unidade)
        {
            _admBoaFeDbContext.UnidadeCondominial.Update(unidade);
            _admBoaFeDbContext.SaveChanges();
        }

        public void DeletarUnidadeCondominial(int idUnidade)
        {
            var unidDel = _admBoaFeDbContext.UnidadeCondominial.Find(idUnidade);
            if (unidDel != null)
            {
                _admBoaFeDbContext.UnidadeCondominial.Remove(unidDel);
                _admBoaFeDbContext.SaveChanges();
            }
            
        }

    }
}
