using BlazorHero.CleanArchitecture.Domain.Entities.Sgio;

namespace BlazorHero.Application.Responses.Sgio
{
    public class ContribuableResponse
    {
        public bool Status { get; set; }

        public Contribuable? Data { get; set; }

        public string Message { get; set; }
    }
}
