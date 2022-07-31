
namespace Entra21.Gerenciador.Hospital.Vet.Models
{
    public class Pet
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int Idade { get; set; }
        public decimal Peso { get; set; }
        public decimal Altura { get; set; }
        public char Genero { get; set; }

        public Responsavel Responsavel { get; set; }
        public Raca Raca { get; set; }
    }
}
