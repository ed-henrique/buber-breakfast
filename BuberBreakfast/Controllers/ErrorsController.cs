using Microsoft.AspNetCore.Mvc;

namespace BuberBreakfast.Controllers;

public class ErrorsControllers : ApiController
{
    [Route("/error")]
    public IActionResult Error()
    {
        return Problem();
    }
}