using System;
using System.Collections.Generic;
using System.Text;

namespace MyAWSLambda
{
    public interface IEnvironmentService
    {
        string EnvironmentName { get; set; }
    }
}
