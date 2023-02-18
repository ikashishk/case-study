/** 
 getallBonds and getBond by security added. 
 update and add remaining 
 will do thatF

*/


using case_study.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

[ApiController]
[Route("api/[Controller]")]

public class BondsDataController : ControllerBase
{

    private readonly SecurityMaster_Group9Context _DBContext;

    public BondsDataController()
    {
        _DBContext = new SecurityMaster_Group9Context();
        _DBContext.Database.EnsureCreated();
    }

    [HttpGet("getAllBonds")]
    public async Task<IActionResult> GetAllBonds()
    {
        return Ok(await _DBContext.Bonds.ToListAsync());
    }

    [HttpGet]
    public async Task<IActionResult> GetSecurityByID(int _SecurityID)
    {
        var _Bonds = await _DBContext.Bonds.FindAsync(_SecurityID);
        return _Bonds == null ? NotFound() : Ok(_Bonds);
    }

}