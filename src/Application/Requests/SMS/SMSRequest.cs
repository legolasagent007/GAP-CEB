using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorHero.Application.Requests.SMS
{
    public class SMSRequest
    {
        public string To { get; set; }
        public string Text { get; set; }
        
    }
}
