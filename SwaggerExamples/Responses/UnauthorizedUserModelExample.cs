using Swashbuckle.AspNetCore.Filters;
using AngularWeb.Models.Users;

namespace AngularWeb.SwaggerExamples.Responses
{
    public class UnauthorizedUserModelExample : IExamplesProvider<UnauthorizedUserModel>
    {
        public UnauthorizedUserModel GetExamples()
        {
            return new UnauthorizedUserModel
            {
                ErrorCode = 401,
                ErrorMessage = "Wrong Username or Password"
            };
        }
    }
}
