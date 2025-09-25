using AutoMapper;

namespace Board_Game_API.Mapping {
    public class UserSummaryProfile : Profile {
        public UserSummaryProfile() { 
            CreateMap<Models.User, DTOS.UserSummaryDTO>();
            CreateMap<Models.User, DTOS.UserSummaryDTO>().ReverseMap ();
        }
    }
}
