using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyAWSLambda
{
    public interface IConfigurationService
    {
        IConfiguration GetConfiguration();
    }
}
