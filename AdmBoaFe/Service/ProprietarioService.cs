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
    public class ProprietarioService : IProprietarioService
    {
        private readonly IMapper _mapper;
        private readonly AdmBoaFeDbContext _admBoaFeDbContext;

        public ProprietarioService(AdmBoaFeDbContext admBoaFeDbContext, IMapper mapper)
        {
            _admBoaFeDbContext = admBoaFeDbContext;
            _mapper = mapper;
        }

        public async Task<List<ProprietarioDTO>> ConsultarProprietarios()
        {
            var result = await _admBoaFeDbContext.Proprietario.ToListAsync();
            var lista = _mapper.Map<List<ProprietarioDTO>>(result);

            return lista;

        }

        public async Task<ProprietarioDTO> ConsultarProprietarioPorId(int? Id)
        {
            var result = await _admBoaFeDbContext.Proprietario.FindAsync(Id);
            ProprietarioDTO dto = _mapper.Map<ProprietarioDTO>(result);

            return dto;

        }

        public void InserirProprietario(Proprietario prop)
        {
            _admBoaFeDbContext.Proprietario.Add(prop);
            _admBoaFeDbContext.SaveChanges();
        }

        public void AtualizarProprietario(Proprietario prop)
        {
            _admBoaFeDbContext.Proprietario.Update(prop);
            _admBoaFeDbContext.SaveChanges();
        }

        public void DeletarProprietario(int idProp)
        {
            var propDel = _admBoaFeDbContext.Proprietario.Find(idProp);
            if (propDel != null)
            {
                _admBoaFeDbContext.Proprietario.Remove(propDel);
                _admBoaFeDbContext.SaveChanges();
            }

        }

    }
}
