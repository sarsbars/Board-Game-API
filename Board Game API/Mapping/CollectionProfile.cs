using AutoMapper;

namespace Board_Game_API.Mapping {
    public class CollectionProfile : Profile {
        public CollectionProfile () {
            CreateMap<Models.Collection, DTOS.CollectionDTO>();
            CreateMap<Models.Collection, DTOS.CollectionDTO>().ReverseMap();
        }
    }
}
