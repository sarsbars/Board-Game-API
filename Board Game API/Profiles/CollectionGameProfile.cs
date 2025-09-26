using AutoMapper;
using Board_Game_API.DTOS;
using Board_Game_API.Models;

namespace Board_Game_API.Profiles {
    public class CollectionGameProfile : Profile {
        
        public CollectionGameProfile() {

            CreateMap<CollectionGame, CollectionGameDTO>().ReverseMap();

        }
    }
}
