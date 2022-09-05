using System.Threading.Tasks;
using BlazorHero.Application.Requests.Sgio;
using BlazorHero.Application.Responses.Sgio;

namespace BlazorHero.Application.Interfaces.Services
{
    public interface ISgioService
    {
        Task<DeclarationResponse> CreateDeclaration (DeclarationRequest request);
        Task<DeclarationResponse> CreatePenality (PenaliteRequest request);
        Task<DeclarationResponse> CheckPaiementStatut(long refDeclaration);
        Task<ContribuableResponse> ChercheContribuable(string nif);
    }
}
