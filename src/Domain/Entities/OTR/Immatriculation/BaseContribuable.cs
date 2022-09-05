using BlazorHero.CleanArchitecture.Domain.Contracts;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlazorHero.CleanArchitecture.Domain.Entities.OTR.Immatriculation;
public abstract class BaseContribuable : AuditableEntity<int>
{
    [Column(TypeName = "varchar(20)")]
    public string Nif { get; set; }

    [Column(TypeName = "varchar(100)")]
    public string? Nom { get; set; }

    [Column(TypeName = "varchar(100)")]
    public string? Prenom { get; set; }

    [MaxLength(200)]
    [Column(TypeName = "varchar(200)")]
    public string? RaisonSociale { get; set; }

    [Column(TypeName = "varchar(200)")]
    public string? RegimeFiscal { get; set; }

    [Column(TypeName = "varchar(200)")]
    public string? ActivitePrincipale { get; set; }

    [Column(TypeName = "varchar(100)")]
    public string? FormeJuridique { get; set; }

    [Column(TypeName = "varchar(15)")]
    public string? Telephone { get; set; }

    [EmailAddress]
    [Column(TypeName = "varchar(255)")]
    public string? Email { get; set; }

    [Column(TypeName = "varchar(200)")]
    public string? AdressePostale { get; set; }

    [Column(TypeName = "varchar(200)")]
    public string? AdresseGeographique { get; set; }

}

