using AngularWeb.Models;
using Swashbuckle.AspNetCore.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AngularWeb.SwaggerExamples.Responses
{
    public class ErrorHandlingModelExample : IExamplesProvider<ErrorHandlingModel>
    {
        public ErrorHandlingModel GetExamples()
        {
            return new ErrorHandlingModel
            {
                Errors =
                 new List<Error>
                 {
                     new Error { ErrorMessage = "User not found", ErrorCode = 401 },
                     new Error { ErrorMessage = "password incorrect", ErrorCode = 401 }
                 }
            };
        }
    }
}
