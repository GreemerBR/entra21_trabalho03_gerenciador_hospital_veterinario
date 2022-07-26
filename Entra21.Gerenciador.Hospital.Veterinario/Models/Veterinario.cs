namespace Entra21.Gerenciador.Hospital.Vet.Models
{
    internal class Veterinario
    {
        public int Id { get; set; }
        public int Idade { get; set; }
        public int Telefone { get; set; }
        public int CrmvNumero { get; set; }
        public string Cpf { get; set; }
        public string CrmvEstado { get; set; }
        public string Especialidade { get; set; }
        public string Nome { get; set; }
        public bool StatusHorario { get; set; }
    }
}
