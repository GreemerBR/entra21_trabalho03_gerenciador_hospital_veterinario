namespace Entra21.Gerenciador.Hospital.Veterinario.Models
{
    internal class Consulta
    {
        public int Id { get; set; }
        public DateTime Data { get; set; }
        public DateTime Hora { get; set; }
        public string Observacao { get; set; }

        public Veterinario Veterinario { get; set; }
        public Pet Pet { get; set; }
    }
}
