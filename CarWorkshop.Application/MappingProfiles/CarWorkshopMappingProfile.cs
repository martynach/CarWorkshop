using AutoMapper;
using CarWorkshop.Application.Dtos;
using CarWorkshop.Domain.Entities;

namespace CarWorkshop.Application.MappingProfiles;

public class CarWorkshopMappingProfile: Profile
{

    public CarWorkshopMappingProfile()
    {
        CreateMap<CarWorkshopDto, Domain.Entities.CarWorkshop>()
            .ForMember(carWorkshop => carWorkshop.ContactDetails,
                config => config.MapFrom(
                    dto => new CarWorkshopContactDetails()
                    {
                        PhoneNumber = dto.PhoneNumber,
                        Street = dto.Street,
                        PostalCode = dto.PostalCode,
                        City = dto.City

                    }));

        CreateMap<Domain.Entities.CarWorkshop, CarWorkshopDto>()
            .ForMember(dto => dto.Street,
                config => config.MapFrom(
                    cw => cw.ContactDetails.Street))
            .ForMember(dto => dto.PhoneNumber,
                config => config.MapFrom(
                    cw => cw.ContactDetails.PhoneNumber))
            .ForMember(dto => dto.City,
                config => config.MapFrom(
                    cw => cw.ContactDetails.City))
            .ForMember(dto => dto.PostalCode,
                config => config.MapFrom(
                    cw => cw.ContactDetails.PostalCode));
    }
    
    
}