using AutoMapper;
using Board_Game_API.DTOS;
using Board_Game_API.Models;

namespace Board_Game_API.Profiles {
    public class MappingProfile : Profile { 
        public MappingProfile() { 
            
            CreateMap<Collection, CollectionDTO>().ReverseMap();

            CreateMap<Session, SessionDTO>().ReverseMap();
            CreateMap<User, UserDTO>().ReverseMap();
            CreateMap<User, UserSummaryDTO>().ReverseMap();
            CreateMap<PlayParticipant, PlayParticipantDTO>().ReverseMap();
        }
    }
}
