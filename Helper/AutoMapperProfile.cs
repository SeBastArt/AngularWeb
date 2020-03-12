using AngularWeb.Entities;
using AngularWeb.Models;
using AngularWeb.Models.User;
using AutoMapper;

namespace AngularWeb.Helper
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<User, UserModel>();
            CreateMap<RegisterModel, User>();
            CreateMap<UpdateModel, User>();
            CreateMap<WeatherForecast, WeatherForecastModel>();
        }
    }
}
