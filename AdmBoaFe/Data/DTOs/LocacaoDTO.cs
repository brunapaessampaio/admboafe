using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace AdmBoaFe.App.Data.Entities;

public class LocacaoDTO
{
    public int Id_Locacao { get; set; }

    public int? Id_Unidade_Condominal { get; set; }

    public int? Id_Locatario { get; set; }

    public decimal? Valor_Aluguel { get; set; }

    public decimal? Taxa_Condominio { get; set; }

    public decimal? Taxa_Iptu { get; set; }

    public DateTime? Data_Inicio_Locacao { get; set; }

    public DateTime? Data_Fim_Locacao { get; set; }

    public LocatarioDTO? LocatarioDTO { get; set; }
    public UnidadeCondominialDTO? UnidadeCondominialDTO { get; set; }


}
