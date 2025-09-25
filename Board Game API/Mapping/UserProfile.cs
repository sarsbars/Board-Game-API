using AutoMapper;

namespace Board_Game_API.Mapping {
    public class UserProfile : Profile {
        public UserProfile () {
            CreateMap<Models.User, DTOS.UserDTO>();
            CreateMap<Models.User, DTOS.UserDTO>().ReverseMap();
        }
    }
}
