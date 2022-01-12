using AutoMapper;
using InstrumentShop.Dtos;
using InstrumentShop.Models;

namespace InstrumentShop.Profiles

{
    public class InstrumentsProfile : Profile
    {
        // Source -> Target
        public InstrumentsProfile()
        {
            CreateMap<Instrument, InstrumentReadDto>();
            CreateMap<InstrumentCreateDto, Instrument>();
        }
    }
}