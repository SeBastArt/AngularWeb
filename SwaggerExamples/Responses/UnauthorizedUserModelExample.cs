using Swashbuckle.AspNetCore.Filters;
using AngularWeb.Models.Users;
using System.Collections.Generic;
using AngularWeb.Models;

namespace AngularWeb.SwaggerExamples.Responses
{
    public class UnauthorizedUserModelExample : IExamplesProvider<UnauthorizedUserModel>
    {
        public UnauthorizedUserModel GetExamples()
        {
            return new UnauthorizedUserModel
            {
                Errors =
                 new List<Error>
                 {
                     new Error { ErrorMessage = "Unauthorized", ErrorCode = 401 },
                 }
            };
        }
    }
}
