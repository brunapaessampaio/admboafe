using AdmBoaFe.App.Data.DTOs;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace AdmBoaFe.App.Data.Entities;

public class UnidadeCondominialDTO
{
    public int Id_Unidade { get; set; }

    public int? Id_Bloco { get; set; }

    public int? Andar { get; set; }

    public int? Num_Apartamento { get; set; }

    public string? Descricao { get; set; }

    public BlocoDTO? BlocoDTO { get; set; }

}
