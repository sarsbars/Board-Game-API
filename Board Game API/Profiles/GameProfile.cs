using AutoMapper;
using Board_Game_API.Models;
using Board_Game_API.DTOS;

namespace Board_Game_API.Profiles { 
    public class GameProfile : Profile { 
        public GameProfile() { 
            CreateMap<Game, GameDTO>().ReverseMap().ForMember(dest => dest.GameID, opt => opt.Ignore()); 
        }
    }
}
