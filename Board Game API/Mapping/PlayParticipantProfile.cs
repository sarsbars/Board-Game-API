using AutoMapper;

namespace Board_Game_API.Mapping {
    public class PlayParticipantProfile : Profile {
        public PlayParticipantProfile () {
            CreateMap<Models.PlayParticipant, DTOS.PlayParticipantDTO>();
            CreateMap<Models.PlayParticipant, DTOS.PlayParticipantDTO>().ReverseMap();
        }
    }
}
