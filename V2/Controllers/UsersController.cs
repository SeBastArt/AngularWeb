using System;
using System.Collections.Generic;
using System.Globalization;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Net;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using AngularWeb.Data;
using AngularWeb.Entities;
using AngularWeb.Helper;
using AngularWeb.Models;
using AngularWeb.Models.User;
using AngularWeb.Services;
using AngularWeb.V1.Controllers;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using Swashbuckle.AspNetCore.Annotations;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using AngularWeb.Models.Users;

namespace AngularWeb.V2.Controllers
{
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiVersion("2.0")]
    [ApiController]
    public class UsersController : BaseController
    {
        private readonly IUserService _userService;
        private readonly IMapper _mapper;
        private readonly AppSettings _appSettings;
        private readonly DataContext _context;

        public UsersController(
            DataContext context,
            IUserService userService,
            IMapper mapper,
            IOptions<AppSettings> appSettings) : base(mapper)
        {
            _userService = userService;
            _context = context;
            if (appSettings != null)
                _appSettings = appSettings.Value;
        }

        /// <summary>
        /// Authenticate a user an give back a bearer token 
        /// </summary>
        /// <response code="200">Returns the newly created barer token and user</response>
        /// <response code="401">Wrong password</response>     
        [ProducesResponseType(typeof(ValidUserModel), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ErrorHandlingModel), StatusCodes.Status401Unauthorized)]
        [AllowAnonymous]
        [HttpPost("authenticate")]
        public IActionResult Authenticate([FromBody]AuthenticateModel model)
        {
            User user  = null;
            if (model != null)
                user = _userService.Authenticate(model.UserName, model.Password);

            if (user == null)
                return BadRequest(new ErrorHandlingModel { Errors = new List<Error> { new Error { ErrorMessage = "User not found or password incorrect", ErrorCode = 401 } } });

            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes(_appSettings.Secret);
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new Claim[]
                {
                    new Claim(ClaimTypes.Name, user.Id.ToString(CultureInfo.InvariantCulture)),
                    new Claim(ClaimTypes.Role, user.Role)
                }),
                Expires = DateTime.Now.AddDays(7),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
            };

            var token = tokenHandler.CreateToken(tokenDescriptor);
            var tokenString = tokenHandler.WriteToken(token);

            return Ok(new ValidUserModel
            {
                UserId = user.Id,
                Username = user.Username,
                FirstName = user.FirstName,
                LastName = user.LastName,
                Token = tokenString
            });
        }
        /// <summary>
        /// Register a new User
        /// </summary>
        /// <param name="model"></param>
        /// <returns>nothing</returns>
        [AllowAnonymous]
        [HttpPost("register")]
        public IActionResult Register([FromBody]RegisterModel model)
        {
            var user = _mapper.Map<User>(model);

            try
            {
                if (model != null)
                    _userService.Create(user, model.Password);
                return Ok();
            }
            catch (AppException ex)
            {
                // return error message if there was an exception
                return BadRequest(new { message = ex.Message });
            }
        }

        [Authorize(Roles = Role.Admin)]
        [HttpGet]
        public IActionResult GetAll(int? page = null, int pageSize = 10, string orderBy = nameof(AngularWeb.Entities.User.Id), bool ascending = true)
        {
            if (page == null) { 
                return Ok(_context.Users);
            }

            var users = CreatePagedResults<User, UserModel>
                (_context.Users, page.Value, pageSize, orderBy, ascending);
            return Ok(users);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(long id)
        {
            var user = _userService.GetById(id);
            var model = _mapper.Map<UserModel>(user);
            return Ok(model);
        }

        [HttpPut("{id}")]
        public IActionResult Update(Guid id, [FromBody]UpdateModel model)
        {
            // map model to entity and set id
            var user = _mapper.Map<User>(model);

            try
            {
                // update user 
                _userService.Update(user, model.Password);
                return Ok();
            }
            catch (AppException ex)
            {
                // return error message if there was an exception
                return BadRequest(new { message = ex.Message });
            }
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(long id)
        {
            _userService.Delete(id);
            return Ok();
        }
    }
}