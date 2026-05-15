using ECommerceAPI.Models;
using ECommerceAPI.Services;
using Microsoft.AspNetCore.Mvc;

namespace ECommerceAPI.Controllers;
[ApiController]
[Route("api/[controller]")]
public class UserController:ControllerBase
{
    private readonly IUserService _service;

    public UserController(IUserService service)
    {
        _service = service;
    }

    [HttpPost]
    public IActionResult Register(User user)
    {
        return Ok(_service.RegisterUser(user));
    }
}