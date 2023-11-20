using Microsoft.EntityFrameworkCore;
using AdmBoaFe.Data;
using AdmBoaFe.App.Interface.Service;
using AdmBoaFe.App.Service;
using AutoMapper;
using AdmBoaFe.App.Data.DTOs;
using AdmBoaFe.App.Data.Entities;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

builder.Services.AddDbContext<AdmBoaFeDbContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("AdmBoaFeDbConnection"));
});

builder.Services.AddEndpointsApiExplorer();

// injeção de dependencia
builder.Services.AddScoped<IBlocoService, BlocoService>();
builder.Services.AddScoped<ICondominioService, CondominioService>();
builder.Services.AddScoped<ILocacaoService, LocacaoService>();
builder.Services.AddScoped<ILocatarioService, LocatarioService>();
builder.Services.AddScoped<IManutencaoService, ManutencaoService>();
builder.Services.AddScoped<IProprietarioService, ProprietarioService>();
builder.Services.AddScoped<IUnidadeCondominialService, UnidadeCondominialService>();

//automapper
var config = new AutoMapper.MapperConfiguration(cfg =>
{
    cfg.CreateMap<Bloco, BlocoDTO>();
    cfg.CreateMap<Condominio, CondominioDTO>();
    cfg.CreateMap<Locacao, LocacaoDTO>();
    cfg.CreateMap<Locatario, LocatarioDTO>();
    cfg.CreateMap<Manutencao, ManutencaoDTO>();
    cfg.CreateMap<Proprietario, ProprietarioDTO>();
    cfg.CreateMap<UnidadeCondominial, UnidadeCondominialDTO>();
});

IMapper mapper = config.CreateMapper();

builder.Services.AddSingleton(mapper);

builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();

