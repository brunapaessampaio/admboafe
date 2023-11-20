using AdmBoaFe.App.Data.Entities;

namespace AdmBoaFe.App.Data.DTOs
{
    public class BlocoDTO
    {
        public int Id_Bloco { get; set; }
        public string? Nome_Bloco { get; set; }
        public int? Id_Condominio { get; set; }
        public CondominioDTO? CondominioDTO { get; set; }
    }
}
