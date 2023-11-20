using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace AdmBoaFe.App.Data.Entities;

public class LocatarioDTO
{
    public int Id_Locatario { get; set; }

    public string? Nome { get; set; }

    public DateTime? Data_Nasc { get; set; }

    public string? Cpf { get; set; }

    public string? Rg { get; set; }

    public string? Telefone { get; set; }

    public string? Email { get; set; }

}
