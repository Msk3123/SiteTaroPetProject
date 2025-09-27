using AutoMapper;
using Entities.DTO;
using Entities.Models;

namespace AM;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        // CreateMap<User, UserDto>().ReverseMap();
       // CreateMap<CartTaro, CartTaroDto>().ReverseMap(); 
       CreateMap<DtoCartTaroCreate, CartTaro>();
       CreateMap<CartTaro, DtoCartTaro>();


       // Поки хай буде так бо пізніше потрібно буде замінити і ревалізувати
       // і замінити без Reserve бо воно трохи не підходить.
    }
}