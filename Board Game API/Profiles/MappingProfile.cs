using AutoMapper;
using Board_Game_API.DTOS;
using Board_Game_API.Models;

namespace Board_Game_API.Profiles {
    public class MappingProfile : Profile { 
        public MappingProfile() { 
            CreateMap<Game, GameDTO>().ReverseMap();
            CreateMap<Game, GameSummaryDTO>().ReverseMap();
            CreateMap<Collection, CollectionDTO>().ReverseMap();
            CreateMap<CollectionGame, CollectionGameDTO>().ReverseMap();
            CreateMap<Session, SessionDTO>().ReverseMap();
            CreateMap<User, UserDTO>().ReverseMap();
            CreateMap<User, UserSummaryDTO>().ReverseMap();
            CreateMap<PlayParticipant, PlayParticipantDTO>().ReverseMap();
        }
    }
}
