using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using case_study.Model;

namespace net.Controllers;

[ApiController]
[Route("[controller]")]
public class BondController : ControllerBase
{
    
    private readonly SecurityMaster_Group9Context _DBContext;

    public BondController(SecurityMaster_Group9Context dbcontext)
    {
        this._DBContext=dbcontext;
    }
   
    [HttpGet("GetBond")]
    public IActionResult GetAll()
    {
        var product=this._DBContext.Bonds.ToList();
        return Ok(product);
    }
}