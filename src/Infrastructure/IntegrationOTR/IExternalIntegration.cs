using BlazorHero.CleanArchitecture.Domain.Entities.OTR.Immatriculation;
using BlazorHero.CleanArchitecture.Domain.Entities.OTR.Impots;
using BlazorHero.Infrastructure.IntegrationOTR.Model;
using System.Threading.Tasks;

namespace BlazorHero.Infrastructure.IntegrationOTR;

public interface IExternalIntegration
{
    Task<DeclarationResponse> CreateDeclaration (DeclarationRequest request);
    Task<DeclarationResponse> CreatePenality (PenaliteRequest request);
}
