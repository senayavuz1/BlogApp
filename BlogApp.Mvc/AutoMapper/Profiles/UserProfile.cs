using AutoMapper;
using BlogApp.Entities.Concrete;
using BlogApp.Entities.Dtos;

namespace BlogApp.Mvc.AutoMapper.Profiles
{
    public class UserProfile:Profile
    {
        public UserProfile() 
        {
            CreateMap<UserAddDto, User>();
        }
    }
}                                                   // 78.Videoooo
