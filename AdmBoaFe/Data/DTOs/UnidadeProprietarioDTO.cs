using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace AdmBoaFe.App.Data.Entities;

public class UnidadeProprietarioDTO
{
    public int? Id_Unidade { get; set; }

    public int? Id_Proprietario { get; set; }

    public ProprietarioDTO? ProprietarioDTO { get; set; }

    public UnidadeCondominialDTO? UnidadeCondominialDTO { get; set; }

}
