using System.Threading.Tasks;
using BlazorHero.Application.Interfaces.Services;
using Microsoft.AspNetCore.Mvc;

namespace BlazorHero.CleanArchitecture.Server.Controllers.v1.Sgio
{
    public class SgioController : BaseApiController<SgioController>
    {
        private readonly ISgioService _sgioService;

        public SgioController(ISgioService sgioService)
        {
            _sgioService = sgioService;
        }

        [HttpGet("chercher-contribuable{nif}")]
        public async Task<IActionResult> ChercherContribuable(string nif)
        {
            var contribuable = await _sgioService.ChercheContribuable(nif);
            return Ok(contribuable);
        }
    }
}