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
    public class LocatarioService: ILocatarioService
    {
        private readonly IMapper _mapper;
        private readonly AdmBoaFeDbContext _admBoaFeDbContext;

        public LocatarioService(AdmBoaFeDbContext admBoaFeDbContext, IMapper mapper)
        {
            _admBoaFeDbContext = admBoaFeDbContext;
            _mapper = mapper;
        }

        public async Task<List<LocatarioDTO>> ConsultarLocatarios()
        {
            var result = await _admBoaFeDbContext.Locatario.ToListAsync();
            var lista =  _mapper.Map<List<LocatarioDTO>>(result);

            return lista;

        }

        public async Task<LocatarioDTO> ConsultarLocatarioPorId(int? Id)
        {
            var result = await _admBoaFeDbContext.Locatario.FindAsync(Id);
            LocatarioDTO dto = _mapper.Map<LocatarioDTO>(result);

            return dto;

        }

        public void InserirLocatario(Locatario locatario)
        {
            _admBoaFeDbContext.Locatario.Add(locatario);
            _admBoaFeDbContext.SaveChanges();
        }

        public void AtualizarLocatario(Locatario locatario)
        {
            _admBoaFeDbContext.Locatario.Update(locatario);
            _admBoaFeDbContext.SaveChanges();
        }

        public void DeletarLocatario(int idLocatario)
        {
            var locDel = _admBoaFeDbContext.Locatario.Find(idLocatario);
            if (locDel != null)
            {
                _admBoaFeDbContext.Locatario.Remove(locDel);
                _admBoaFeDbContext.SaveChanges();
            }
            
        }

    }
}
