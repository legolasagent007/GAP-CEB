namespace BlazorHero.Application.Responses.Sgio
{
    public class PaiementResponse : DeclarationResponse
    {
        public int RefPaiement { get; set; }

        public string CodeBanque { get; set; }

        public string MontantPaye { get; set; }

        public string DateOperation { get; set; }

        public string TypeOperation { get; set; }
    }
}
