using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using case_study.Model;

namespace net.Controllers;

[ApiController]
[Route("[controller]")]
public class EquityController : ControllerBase
{
    
    private readonly SecurityMaster_Group9Context _DBContext;

    public EquityController(SecurityMaster_Group9Context dbcontext)
    {
        this._DBContext=dbcontext;
    }
   
    [HttpGet("GetEquity")]
    public IActionResult GetAll()
    {
        var product=this._DBContext.Equities.ToList();
        return Ok(product);
    }
}