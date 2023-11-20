using AdmBoaFe.App.Data.Entities;

namespace AdmBoaFe.App.Data.DTOs
{
    public class CondominioDTO
    {
        public int Id_Condominio { get; set; }
        public string? Nome_Condominio { get; set; }
        public string? Logradouro { get; set; }
        public int? Numero { get; set; }
        public string? Complemento { get; set; }
        public string? Bairro { get; set; }
        public string? Cidade { get; set; }
        public string? Uf { get; set; }
        public string? Cep { get; set; }
    }
}
