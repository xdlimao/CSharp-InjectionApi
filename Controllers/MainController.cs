using InjectionApi.Services;
using Microsoft.AspNetCore.Mvc;

namespace InjectionApi.Controllers;

[ApiController]
[Route("")]
public class MainController : ControllerBase
{
    private readonly IPedido _pedido;
    public MainController(IPedido pedido)
    {
        _pedido = pedido; 
    }
    [HttpGet]
    [Route("")]
    public IActionResult GetPedido()
    {
        return Ok(_pedido.ProcessarPedido());
    }
}

