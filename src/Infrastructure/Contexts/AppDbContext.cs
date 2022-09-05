using BlazorHero.CleanArchitecture.Domain.Entities.Sgio;
using Microsoft.EntityFrameworkCore;

namespace BlazorHero.CleanArchitecture.Infrastructure.Contexts;

public partial class BlazorHeroContext
{
    public DbSet<Contribuable> Contribuables { get; set; }
    public DbSet<Declaration> Declarations { get; set; }
}