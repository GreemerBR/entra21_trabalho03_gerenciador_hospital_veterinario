
namespace Entra21.Gerenciador.Hospital.Vet.Models
{
    public class Pet
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int Idade { get; set; }
        public double Peso { get; set; }
        public double Altura { get; set; }
        public string Genero { get; set; }
        public Responsavel Responsavel { get; set; }
        public Raca Raca { get; set; }
    }
}
