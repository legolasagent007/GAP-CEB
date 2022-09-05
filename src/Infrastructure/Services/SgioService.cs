using System;
using System.Collections.Specialized;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using System.Web;
using Flurl;
using Flurl.Http;
using BlazorHero.Application.Interfaces.Services;
using BlazorHero.Application.Requests.Sgio;
using BlazorHero.Application.Responses.Sgio;
using BlazorHero.CleanArchitecture.Infrastructure.Contexts;
using BlazorHero.Infrastructure.Extensions;
using Microsoft.Extensions.Configuration;

namespace BlazorHero.Infrastructure.Services
{

    public class SgioService : ISgioService
    {
        private string _baseUrl { get; init; }
        private string _userName { get; init; }
        private string _passWord { get; init; }

        private const string _eServiceMethod = "get-taxpayer";

        private const string _declarationMethod = "save-declaration";

        private const string _paymentMethod = "check-payment";

        protected readonly JsonSerializerOptions jsonSerializerOptions;

        private readonly IConfiguration _config;

        private BlazorHeroContext _context;
        
        public SgioService (BlazorHeroContext context, IConfiguration config)
        {
            _config = config;
            _context = context;
            _baseUrl = _config["SGIO:base_url"];
            _userName = _config["SGIO:username"];
            _passWord = _config["SGIO:password"];
            jsonSerializerOptions = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            };

        }

        public Task<DeclarationResponse> CreateDeclaration (DeclarationRequest request)
        {
            return  _baseUrl.WithBasicAuth(_userName, _passWord)
                .AppendPathSegment(_declarationMethod)
                .PostAsync(request.ToStringContent())
                .ReceiveJson<DeclarationResponse>();
        }

        public Task<DeclarationResponse> CreatePenality (PenaliteRequest request)
        {
            return _baseUrl.WithBasicAuth(_userName, _passWord)
                .AppendPathSegment(_declarationMethod)
                .PostAsync(request.ToStringContent())
                .ReceiveJson<DeclarationResponse>();
        }

        public Task<DeclarationResponse> CheckPaiementStatut(long refDeclaration)
        {
            throw new NotImplementedException();
        }

        public async Task<ContribuableResponse> ChercheContribuable(string nif)
        {
            var contribuable = _context.Contribuables.AsQueryable().FirstOrDefault(c => c.NIF == nif);
            if (contribuable == null)
            {
                var contribuableResponse = await GetContribuableAsync(nif);
                return contribuableResponse;
            }

            return new ContribuableResponse()
            {
                Data = contribuable,
                Message = "",
                Status = true
            };
        }
        
        private async Task<ContribuableResponse> GetContribuableAsync(string nif)
        {
            NameValueCollection queryString = HttpUtility.ParseQueryString(string.Empty);
            
            queryString.Add("nif", nif);

            string postData = queryString.ToString();

            return await _baseUrl.AppendPathSegment(_eServiceMethod)
                .WithBasicAuth(_userName, _passWord)
                .PostUrlEncodedAsync(postData)
                .ReceiveJson<ContribuableResponse>();
        }
    }

}
