namespace BlazorHero.CleanArchitecture.Domain.Entities.OTR.Impots;

using BlazorHero.CleanArchitecture.Domain.Contracts;

using Microsoft.EntityFrameworkCore;

using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

[Index(nameof(RefDeclaration), IsUnique = true)]
public abstract class BaseDeclaration : AuditableEntity<int>
{
    public long RefDeclaration { get; set; }
    public int RefPaiement { get; set; }
    [Column(TypeName = "varchar(20)")]
    public string CodeBanque { get; set; }
    public DateTime? DateOperation { get; set; }
    public DateTime DateEcheance { get; set; }
    [Range(0, Double.PositiveInfinity)]
    [Column(TypeName = "decimal(18, 2)")]
    public decimal Montant { get; set; }
    [Range(0, Double.PositiveInfinity)]
    [Column(TypeName = "decimal(18, 2)")]
    public decimal MontantPaye { get; set; }
    [Range(0, Double.PositiveInfinity)]
    [Column(TypeName = "decimal(18, 2)")]
    public decimal Solde { get; set; }
    [Column(TypeName = "varchar(20)")]
    public string TypeOperation { get; set; }
    public bool IsPenalite { get; set; }
}
