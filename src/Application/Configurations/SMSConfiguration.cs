using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorHero.Application.Configurations
{
    public class SMSConfiguration
    {
        public string Host { get; set; }        
        public string User { get; set; }
        public string Password { get; set; }
        public string Origin { get; set; }
        public string From { get; set; }

    }
}
