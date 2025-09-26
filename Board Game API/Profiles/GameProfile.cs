using AutoMapper;
using Board_Game_API.DTOS;
using Board_Game_API.Models;

namespace Board_Game_API.Profiles {
    public class GameProfile : Profile {
        public GameProfile() {
            CreateMap<Game, GameDTO>().ReverseMap();
            CreateMap<Game, GameSummaryDTO>().ReverseMap();
        }
    }
}

