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
    public class ManutencaoService: IManutencaoService
    {
        private readonly IMapper _mapper;
        private readonly AdmBoaFeDbContext _admBoaFeDbContext;
        private readonly IUnidadeCondominialService _unidService;

        public ManutencaoService(AdmBoaFeDbContext admBoaFeDbContext, IMapper mapper, IUnidadeCondominialService unidService)
        {
            _admBoaFeDbContext = admBoaFeDbContext;
            _mapper = mapper;
            _unidService = unidService;
        }

        public async Task<List<ManutencaoDTO>> ConsultarManutencoes()
        {
            var result = await _admBoaFeDbContext.Manutencao.ToListAsync();
            var lista =  _mapper.Map<List<ManutencaoDTO>>(result);

            foreach (var item in lista)
            {
                item.UnidadeCondominialDTO = _unidService.ConsultarUnidadeCondominialPorId(item.Id_Unidade_Condominial).Result;
            }

            return lista;

        }

        public async Task<ManutencaoDTO> ConsultarManutencaoPorId(int Id)
        {
            var result = await _admBoaFeDbContext.Manutencao.FindAsync(Id);
            ManutencaoDTO dto = _mapper.Map<ManutencaoDTO>(result);

            dto.UnidadeCondominialDTO = _unidService.ConsultarUnidadeCondominialPorId(dto.Id_Unidade_Condominial).Result;

            return dto;

        }

        public void InserirManutencao(Manutencao manut)
        {
            _admBoaFeDbContext.Manutencao.Add(manut);
            _admBoaFeDbContext.SaveChanges();
        }

        public void AtualizarManutencao(Manutencao manut)
        {
            _admBoaFeDbContext.Manutencao.Update(manut);
            _admBoaFeDbContext.SaveChanges();
        }

        public void DeletarManutencao(int idManut)
        {
            var manutDel = _admBoaFeDbContext.Manutencao.Find(idManut);
            if (manutDel != null)
            {
                _admBoaFeDbContext.Manutencao.Remove(manutDel);
                _admBoaFeDbContext.SaveChanges();
            }
            
        }

    }
}
