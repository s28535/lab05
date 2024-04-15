using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers;

[Route("api/vists")]
[ApiController]
public class VisitController : ControllerBase
{
    private static readonly List<Visit> _visits = new()
    {
        new Visit{Date = new DateTime(2024, 1, 5), AnimalId = 1, Description = "operation", Price = 1500},
        new Visit{Date = new DateTime(2024, 2, 16), AnimalId = 2, Description = "foo", Price = 75},
        new Visit{Date = new DateTime(2024, 3, 17), AnimalId = 3, Description = "control visit", Price = 50},
        new Visit{Date = new DateTime(2024, 4, 3), AnimalId = 3, Description = "drug injection", Price = 149.99}
    };
    
    [HttpGet("{id:int}")]
    public IActionResult GetVisits(int id)
    {
        var visit = _visits.FindAll(s => s.AnimalId == id);
        if (visit == null)
        {
            return NotFound($"Animal with id {id} was not found");
        }

        return Ok(visit);
    }

    [HttpPost]
    public IActionResult CreateVisit(Visit visit)
    {
        _visits.Add(visit);
        return StatusCode(StatusCodes.Status201Created);
    }
}