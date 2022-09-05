using BlazorHero.Application.Models.Sgio;

namespace BlazorHero.Application.Requests.Sgio
{
    public class DeclarationRequest : ContribRequestBody
    {
        public int liquidation { get; set; }

        public decimal montant { get; set; }

        public string designation { get; set; }

        public decimal penalite { get; set; }

        public int imptax { get; set; }

        public string poste { get; set; }
    }
}