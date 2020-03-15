using Swashbuckle.AspNetCore.Filters;
using AngularWeb.Models;

namespace AngularWeb.SwaggerExamples.Responses
{
    public class ValidUserModelExample : IExamplesProvider<ValidUserModel>
    {
        public ValidUserModel GetExamples()
        {
            return new ValidUserModel
            {
                UserId = 1,
                Username = "user",
                FirstName = "Pete",
                LastName = "Mista",
                Token = "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJ1bmlxdWVfbmFtZSI..."
            };
        }
    }
}
