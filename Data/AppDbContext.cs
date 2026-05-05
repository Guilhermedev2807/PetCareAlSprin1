using Microsoft.EntityFrameworkCore;
using PetCareAI.Models;

namespace PetCareAI.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

    public DbSet<Pet> Pets { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // Mapeamento para o padrão de tabelas da FIAP
        modelBuilder.Entity<Pet>().ToTable("TB_PETCARE_PETS");
    }
}