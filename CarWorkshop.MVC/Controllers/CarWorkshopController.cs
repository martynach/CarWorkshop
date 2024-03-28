using CarWorkshop.Application.Dtos;
using CarWorkshop.Application.Services;
using Microsoft.AspNetCore.Mvc;

namespace CarWorkshop.MVC.Controllers;

public class CarWorkshopController: Controller
{
    private readonly ICarWorkshopService _carWorkshopService;

    public CarWorkshopController(ICarWorkshopService carWorkshopService)
    {
        _carWorkshopService = carWorkshopService;
    }

    public ActionResult Create()
    {
        return View();
    }
    


    // [HttpPost("Create")]
    [HttpPost]
    public async Task<IActionResult> Create( [FromForm] CarWorkshopDto carWorkshopDto)
    {
        await _carWorkshopService.Create(carWorkshopDto);
        return RedirectToAction(nameof(Create)); // todo

    }

}