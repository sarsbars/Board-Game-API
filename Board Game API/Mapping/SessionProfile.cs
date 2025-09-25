using AutoMapper;

namespace Board_Game_API.Mapping {
    public class SessionProfile : Profile {
        public SessionProfile () {
            CreateMap<Models.Session, DTOS.SessionDTO>();
            CreateMap<Models.Session, DTOS.SessionDTO>().ReverseMap();
        }
    }
}
