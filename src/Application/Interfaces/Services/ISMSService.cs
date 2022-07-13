using BlazorHero.Application.Requests.SMS;
using BlazorHero.CleanArchitecture.Application.Interfaces.Services;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorHero.Application.Interfaces.Services
{
    public interface ISMSService
    {
        Task SendAsync (SMSRequest request);
    }
}
