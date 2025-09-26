using AutoMapper;
using Board_Game_API.DTOS;
using Board_Game_API.Models;

namespace Board_Game_API.Profiles {
    public class PlayParticipantProfile : Profile {

        public PlayParticipantProfile() {

            CreateMap<PlayParticipant, PlayParticipantDTO>().ReverseMap();
        }
    }
}