using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace AdmBoaFe.App.Data.Entities;

public class Bloco
{
    [Key]
    public int Id_Bloco { get; set; }
    public string? Nome_Bloco { get; set; }
    public int? Id_Condominio { get; set; } 
}

