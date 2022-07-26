namespace Entra21.Gerenciador.Hospital.Vet.Models
{
    internal class Endereco
    {
        public int Id { get; set; }
        public Responsavel Responsavel { get; set; }
        public string Cep { get; set; }
        public string Logradouro { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string UnidadeFederativa { get; set; }
    }
}
