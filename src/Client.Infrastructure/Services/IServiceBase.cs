using BlazorHero.CleanArchitecture.Domain.Contracts;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BlazorHero.CleanArchitecture.Client.Infrastructure.Services;

public interface ICrudServiceBase<T> where T : AuditableEntity<int>
{
    Task DeleteAsync<T> (T tItem) where T : AuditableEntity<int>;
    IAsyncEnumerable<T> GetAllAsync (string champ_recherche = null, string champ_valeur = null, int page = 0, int count = 0);
    Task<T> GetAsync (int Id);
    Task<T> PostWithResultAsync<T> (T tItem) where T : AuditableEntity<int>;
    Task PostAsync<T> (T tItem) where T : AuditableEntity<int>;
    Task UpdateAsync<T> (T tItem) where T : AuditableEntity<int>;
}
