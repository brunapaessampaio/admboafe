using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AdmBoaFe.App.Data.Entities;

public class UnidadeProprietario
{
    [Key]
    public int? Id_Unidade { get; set; }

    public int? Id_Proprietario { get; set; }

}
