using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace AdmBoaFe.App.Data.Entities;

public class Manutencao
{
    [Key]
    public int Id_Manutencao { get; set; }

    public int? Id_Unidade_Condominial { get; set; }

    public string? Descricao { get; set; }

    public decimal? Taxa_Manutencao { get; set; }

    public DateTime? Data_Manutencao { get; set; }

    public bool? Executada { get; set; }
}
