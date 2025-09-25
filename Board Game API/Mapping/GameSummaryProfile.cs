using AutoMapper;

namespace Board_Game_API.Mapping {
    public class GameSummaryProfile : Profile {
        public GameSummaryProfile () {
            CreateMap<Models.Session, DTOS.GameSummaryDTO>();
            CreateMap<Models.Session, DTOS.GameSummaryDTO>().ReverseMap();
        }
    }
}
