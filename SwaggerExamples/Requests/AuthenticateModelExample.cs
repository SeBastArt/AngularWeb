using Swashbuckle.AspNetCore.Filters;
using AngularWeb.Models.User;

namespace AngularWeb.SwaggerExamples.Requests
{
    public class AuthenticateModelExample : IExamplesProvider<AuthenticateModel>
    {
        public AuthenticateModel GetExamples()
        {
            return new AuthenticateModel
            {
                UserName = "user",
                Password = "password"
            };
        }
    }
}
