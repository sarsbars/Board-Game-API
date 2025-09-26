using AutoMapper;

namespace Board_Game_API.Mapping {
    public class CollectionGameProfile : Profile {
        public CollectionGameProfile () {
            CreateMap<Models.CollectionGame, DTOS.CollectionGameDTO>();
            CreateMap<Models.CollectionGame, DTOS.CollectionGameDTO>().ReverseMap();
            CreateMap<Models.CollectionGame, DTOS.CreateCollectionGameDTO>().ReverseMap();
        }
    }
}
