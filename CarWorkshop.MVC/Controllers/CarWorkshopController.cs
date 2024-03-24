using CarWorkshop.Application.Services;
using Microsoft.AspNetCore.Mvc;

namespace CarWorkshop.MVC.Controllers;
//
// [ApiController]
// [Route("api/carworkshop")]
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

    [HttpPost]
    public async Task<IActionResult> Create([FromBody] Domain.Entities.CarWorkshop carWorkshop)
    {
        await _carWorkshopService.Create(carWorkshop);
        return RedirectToAction(nameof(Create)); // todo

    }

}