using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

using BlazorHero.CleanArchitecture.Domain.Entities.OTR.Immatriculation;
using BlazorHero.Infrastructure.Extensions;
using BlazorHero.Infrastructure.IntegrationOTR.Model;

using Flurl;
using Flurl.Http;

using Microsoft.Extensions.Configuration;

namespace BlazorHero.Infrastructure.IntegrationOTR.Services
{

    public class SgioService : IExternalIntegration
    {
        private string _baseUrl { get; init; }
        private string _userName { get; init; }
        private string _passWord { get; init; }

        private const string _eServiceMethod = "get-taxpayer";

        private const string _declarationMethod = "save-declaration";

        private const string _paymentMethod = "check-payment";

        protected readonly JsonSerializerOptions jsonSerializerOptions;

        private readonly IConfiguration _config;
        
        public SgioService (IConfiguration config)
        {
            _config = config;
            _baseUrl = _config["Api:url"];
            _userName = _config["Api:username"];
            _passWord = _config["Api:password"];            
            jsonSerializerOptions = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            };

        }

        public Task<DeclarationResponse> CreateDeclaration (DeclarationRequest request)
        {
            return  _baseUrl.WithBasicAuth(_userName, _passWord).AppendPathSegment(_declarationMethod).PostAsync(request.ToStringContent()).ReceiveJson<DeclarationResponse>();
        }

        public Task<DeclarationResponse> CreatePenality (PenaliteRequest request)
        {
            return _baseUrl.WithBasicAuth(_userName, _passWord).AppendPathSegment(_declarationMethod).PostAsync(request.ToStringContent()).ReceiveJson<DeclarationResponse>();
        }
    }

}
