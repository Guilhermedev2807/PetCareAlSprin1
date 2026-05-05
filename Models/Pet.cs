namespace PetCareAI.Models;


public class Pet
{
    public int Id { get; set; }
    public string Nome { get; set; } = string.Empty;
    public string Especie { get; set; } = string.Empty; // Cão, Gato, etc.
    public int Idade { get; set; }
    public string Raca { get; set; } = string.Empty;
    public DateTime DataUltimoCheckup { get; set; }
    public double PesoAtual { get; set; }
}