using BlazorHero.CleanArchitecture.Domain.Entities.OTR.Immatriculation;

namespace BlazorHero.Infrastructure.IntegrationOTR.Model;
public class ContribuableResponse
{
    public bool Status { get; set; }

    public BaseContribuable? Data { get; set; }

    public string Message { get; set; }
}
