using AutoMapper;
using Board_Game_API.DTOS;
using Board_Game_API.Models;

namespace Board_Game_API.Profiles {
    public class UserProfile : Profile {

        public UserProfile() {

            CreateMap<User, UserDTO>().ReverseMap();
            CreateMap<User, UserSummaryDTO>().ReverseMap();
            CreateMap<User, CreateUserDTO>().ReverseMap();
        }
    }
}
