namespace Entra21.Gerenciador.Hospital.Vet.Models
{
    internal class Consulta
    {
        public int Id { get; set; }
        public DateTime DataHora { get; set; }
        public string Observacao { get; internal set; }

        public Veterinario Veterinario { get; set; }
        public Pet Pet { get; set; }
    }
}
