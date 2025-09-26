using AutoMapper;
using Board_Game_API.DTOS;
using Board_Game_API.Models;

namespace Board_Game_API.Profiles {
    public class SessionProfile : Profile {

        public SessionProfile() {

            CreateMap<Session, SessionDTO>().ReverseMap();
        }
    }
}