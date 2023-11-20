using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace AdmBoaFe.App.Data.Entities;

public class ProprietarioDTO
{
    public int Id_Proprietario { get; set; }

    public string? Nome { get; set; }

    public DateTime? Data_Nasc { get; set; }

    public string Cpf { get; set; } = null!;

    public string? Rg { get; set; }

    public string? Telefone { get; set; }

    public string? Email { get; set; }
}
