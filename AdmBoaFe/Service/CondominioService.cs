using AdmBoaFe.App.Data.DTOs;
using AdmBoaFe.App.Data.Entities;
using AdmBoaFe.App.Interface.Service;
using AdmBoaFe.Data;
using AutoMapper;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.EntityFrameworkCore;
using NuGet.Protocol.Core.Types;

namespace AdmBoaFe.App.Service
{
    public class CondominioService: ICondominioService
    {
        private readonly IMapper _mapper;
        private readonly AdmBoaFeDbContext _admBoaFeDbContext;

        public CondominioService(AdmBoaFeDbContext admBoaFeDbContext, IMapper mapper)
        {
            _admBoaFeDbContext = admBoaFeDbContext;
            _mapper = mapper;
        }

        public async Task<List<CondominioDTO>> ConsultarCondominios()
        {
            var result = await _admBoaFeDbContext.Condominio.ToListAsync();
            return _mapper.Map<List<CondominioDTO>>(result);
        }

        public async Task<CondominioDTO> ConsultarCondominioPorId(int? Id)
        {
            var cond = await _admBoaFeDbContext.Condominio.FindAsync(Id);
            CondominioDTO dto = _mapper.Map<CondominioDTO>(cond);

            return dto;

        }

        public void InserirCondominio(Condominio cond)
        {
            _admBoaFeDbContext.Condominio.Add(cond);
            _admBoaFeDbContext.SaveChanges();
        }

        public void AtualizarCondominio(Condominio cond)
        {
            _admBoaFeDbContext.Condominio.Update(cond);
            _admBoaFeDbContext.SaveChanges();
        }

        public void DeletarCondominio(int idCondominio)
        {
            var condDel = _admBoaFeDbContext.Condominio.Find(idCondominio);
            if (condDel != null)
            {
                _admBoaFeDbContext.Condominio.Remove(condDel);
                _admBoaFeDbContext.SaveChanges();
            }

        }

    }
}
