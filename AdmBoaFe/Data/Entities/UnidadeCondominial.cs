using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AdmBoaFe.App.Data.Entities;

[Table("Unidade_Condominial")]
public class UnidadeCondominial
{
    [Key]
    public int Id_Unidade { get; set; }

    public int? Id_Bloco { get; set; }

    public int? Andar { get; set; }

    public int? Num_Apartamento { get; set; }

    public string? Descricao { get; set; }

}
