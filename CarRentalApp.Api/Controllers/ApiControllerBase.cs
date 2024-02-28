using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Managmentpropertyapp.Api.Controllers;


[Route("api/properties")]
[ApiController]
public class ApiControllerBase : ControllerBase
{
    private ISender _mediator = null;
    
    protected ISender Mediator => _mediator ??= HttpContext.RequestServices.GetRequiredService<ISender>();
}