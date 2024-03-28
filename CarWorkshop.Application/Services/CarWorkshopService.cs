using AutoMapper;
using CarWorkshop.Application.Dtos;
using CarWorkshop.Domain.Interfaces;

namespace CarWorkshop.Application.Services;

public class CarWorkshopService: ICarWorkshopService
{
    private readonly ICarWorkshopRepository _repository;
    private readonly IMapper _mapper;

    public CarWorkshopService(ICarWorkshopRepository repository, IMapper mapper)
    {
        _repository = repository;
        _mapper = mapper;
    }
    
    public async Task Create(CarWorkshopDto dto)
    {
        var carWorkshop = _mapper.Map<Domain.Entities.CarWorkshop>(dto);
        await _repository.Create(carWorkshop);
    }
}