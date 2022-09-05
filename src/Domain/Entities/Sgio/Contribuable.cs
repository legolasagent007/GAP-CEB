using System.ComponentModel.DataAnnotations.Schema;
using BlazorHero.CleanArchitecture.Domain.Contracts;
using Microsoft.EntityFrameworkCore;

namespace BlazorHero.CleanArchitecture.Domain.Entities.Sgio
{
    [Index(nameof(NIF), IsUnique = true)]
    public class Contribuable: AuditableEntity<int>
    {
        [Column(TypeName = "varchar(100)")]
        public string Email { get; set; }
        [Column(TypeName = "varchar(15)")]
        public string NIF { get; set; }
        [Column(TypeName = "varchar(50)")]
        public string Nom { get; set; }
        [Column(TypeName = "varchar(100)")]
        public string Prenom { get; set; }
        [Column(TypeName = "varchar(255)")]
        public string? RaisonSociale { get; set; }

        [Column(TypeName = "varchar(200)")]
        public string? RegimeFiscal { get; set; }

        [Column(TypeName = "varchar(200)")]
        public string? ActivitePrincipale { get; set; }

        [Column(TypeName = "varchar(100)")]
        public string? FormeJuridique { get; set; }
        
        [Column(TypeName = "varchar(12)")]
        public string Telephone { get; set; }

        [Column(TypeName = "varchar(200)")]
        public string? AdressePostale { get; set; }

        [Column(TypeName = "varchar(200)")]
        public string? AdresseGeographique { get; set; }
    }
}