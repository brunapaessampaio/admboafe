using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace AdmBoaFe.Data.Entities;

public partial class Condominio
{
    [Key]
    public int IdCondominio { get; set; }
    public string? NomeCondominio { get; set; }
    public string? Logradouro { get; set; }
    public int? Numero { get; set; }
    public string? Complemento { get; set; }
    public string? Bairro { get; set; }
    public string? Cidade { get; set; }
    public string? Uf { get; set; }
    public string? Cep { get; set; }
    public virtual ICollection<Bloco> Blocos { get; set; } = new List<Bloco>();
}
