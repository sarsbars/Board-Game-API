using AutoMapper;

namespace Board_Game_API.Mapping {
    public class GameProfile : Profile {
        public GameProfile () {
            CreateMap<Models.Game, DTOS.GameDTO>();
            CreateMap<Models.Game, DTOS.GameDTO>().ReverseMap();
        }
    }
}
