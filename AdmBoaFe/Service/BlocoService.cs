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
    public class BlocoService: IBlocoService
    {
        private readonly IMapper _mapper;
        private readonly AdmBoaFeDbContext _admBoaFeDbContext;
        private readonly ICondominioService _condService;

        public BlocoService(AdmBoaFeDbContext admBoaFeDbContext, IMapper mapper, ICondominioService condService)
        {
            _admBoaFeDbContext = admBoaFeDbContext;
            _mapper = mapper;
            _condService = condService;
        }

        public async Task<List<BlocoDTO>> ConsultarBlocos()
        {
            _admBoaFeDbContext.ChangeTracker.Clear();

            var blocos = await _admBoaFeDbContext.Bloco.ToListAsync();
            var lstBlocos =  _mapper.Map<List<BlocoDTO>>(blocos);

            foreach (var itemBloco in lstBlocos)
            {
                itemBloco.CondominioDTO = _condService.ConsultarCondominioPorId(itemBloco.Id_Condominio).Result;
            }

            return lstBlocos;

        }

        public async Task<BlocoDTO> ConsultarBlocoPorId(int? Id)
        {
            var bloco = await _admBoaFeDbContext.Bloco.FindAsync(Id);
            BlocoDTO dto = _mapper.Map<BlocoDTO>(bloco);

            dto.CondominioDTO = _condService.ConsultarCondominioPorId(dto.Id_Condominio).Result;

            return dto;

        }

        public void InserirBloco(Bloco bloco)
        {
            _admBoaFeDbContext.Bloco.Add(bloco);
            _admBoaFeDbContext.SaveChanges();
        }

        public void AtualizarBloco(Bloco bloco)
        {
            _admBoaFeDbContext.Bloco.Update(bloco);
            _admBoaFeDbContext.SaveChanges();
        }

        public void DeletarBloco(int idBloco)
        {
            var blocoDel = _admBoaFeDbContext.Bloco.Find(idBloco);
            if (blocoDel != null)
            {
                _admBoaFeDbContext.Bloco.Remove(blocoDel);
                _admBoaFeDbContext.SaveChanges();
            }
            
        }

    }
}
