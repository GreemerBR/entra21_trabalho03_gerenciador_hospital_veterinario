namespace Entra21.Gerenciador.Hospital.Veterinario.Models
{
    internal class Endereco
    {
        public int Id { get; set; }
        public Responsavel Responsavel { get; set; }
        public int Cep { get; set; }
        public string Logradouro { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string UnidadeFederativa { get; set; }
    }
}
