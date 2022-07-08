using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorHero.Infrastructure.IntegrationOTR.Model
{
    public class PenaliteRequest: DeclarationRequest
    {
        public long declaration { get; set; }
    }
}
