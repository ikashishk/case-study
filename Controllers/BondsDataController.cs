
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

    [HttpGet]
    [Route("[action]")]
    public async Task<IActionResult> GetAllBonds()
    {
        return Ok(await _DBContext.Bonds.ToListAsync());
    }

    [HttpGet]
    [Route("[action]")]
    public async Task<IActionResult> GetSecurityByID(string _SecurityID)
    {
        var _Bonds = await _DBContext.Bonds.FindAsync(_SecurityID);
        return _Bonds == null ? NotFound() : Ok(_Bonds);
    }

    [HttpPost]
    [Route("[action]")]
    public async Task<IActionResult> CreateBond(CRUDRequestBond crudRequestBond)
    {
        if (crudRequestBond == null) return NotFound();
        var _Bond = new Bond()
        {
            Bid = Guid.NewGuid().ToString(),
            SecurityDescription = crudRequestBond.SecurityDescription,
            SecurityName =crudRequestBond.SecurityName,
            AssetType = crudRequestBond.AssetType,
            InvestmentType = crudRequestBond.InvestmentType,
            TradingFactor = crudRequestBond.TradingFactor,
            PricingFactor = crudRequestBond.PricingFactor,
            Isin = crudRequestBond.Isin,
            BbgTicker = crudRequestBond.BbgTicker,
            BbgUniqueId = crudRequestBond.BbgUniqueId,
            Cusip = crudRequestBond.Cusip,
            Sedol = crudRequestBond.Sedol,
            FirstCouponDate = crudRequestBond.FirstCouponDate,
            Cap = crudRequestBond.Cap,
            Floor = crudRequestBond.Floor,
            CouponFrequency = crudRequestBond.CouponFrequency,
            Coupon = crudRequestBond.Coupon,
            CouponType = crudRequestBond.CouponType,
            Spread = crudRequestBond.Spread,
            CallableFlag = crudRequestBond.CallableFlag,
            FixToFloatFlag = crudRequestBond.FixToFloatFlag,
            PutableFlag = crudRequestBond.PutableFlag,
            IssueDate = crudRequestBond.IssueDate,
            LastResetDate = crudRequestBond.LastResetDate,
            Maturity = crudRequestBond.Maturity,
            CallNotificationMaxDays = crudRequestBond.CallNotificationMaxDays,
            PutNotificationMaxDays = crudRequestBond.PutNotificationMaxDays,
            PenultimateCouponDate = crudRequestBond.PenultimateCouponDate,
            ResetFrequency = crudRequestBond.ResetFrequency,
            HasPosition = crudRequestBond.HasPosition,
            MacaulayDuration = crudRequestBond.MacaulayDuration,
            _30dVolatility = crudRequestBond._30dVolatility,
            _90dVolatility = crudRequestBond._90dVolatility,
            Convexity = crudRequestBond.Convexity,
            _30dayAverageVolume = crudRequestBond._30dayAverageVolume,
            PfAssetClass = crudRequestBond.PfAssetClass,
            PfCountry = crudRequestBond.PfCountry,
            PfCreditRating = crudRequestBond.PfCreditRating,
            PfCurrency = crudRequestBond.PfCurrency,
            PfInstrument = crudRequestBond.PfInstrument,
            PfLiquidityProfile = crudRequestBond.PfLiquidityProfile,
            PfMaturity = crudRequestBond.PfMaturity,
            PfNaicsCode = crudRequestBond.PfNaicsCode,
            PfRegion = crudRequestBond.PfRegion,
            PfSector = crudRequestBond.PfSector,
            PfSubAssetClass = crudRequestBond.PfSubAssetClass,
            BloombergIndustryGroup = crudRequestBond.BloombergIndustryGroup,
            BloombergIndustrySubGroup = crudRequestBond.BloombergIndustrySubGroup,
            BloombergIndustrySector = crudRequestBond.BloombergIndustrySector,
            CountryOfIssuance = crudRequestBond.CountryOfIssuance,
            IssueCurrency = crudRequestBond.IssueCurrency,
            Issuer = crudRequestBond.Issuer,
            RiskCurrency = crudRequestBond.RiskCurrency,
            PutDate = crudRequestBond.PutDate,
            PutPrice = crudRequestBond.PutPrice,
            AskPrice = crudRequestBond.AskPrice,
            HighPrice = crudRequestBond.HighPrice,
            LowPrice = crudRequestBond.LowPrice,
            OpenPrice = crudRequestBond.OpenPrice,
            Volume = crudRequestBond.Volume,
            BidPrice = crudRequestBond.BidPrice,
            LastPrice = crudRequestBond.LastPrice,
            CallDate = crudRequestBond.CallDate,
            CallPrice = crudRequestBond.CallPrice
        };
        await _DBContext.Bonds.AddAsync(_Bond);
        await _DBContext.SaveChangesAsync();
        return Ok(_Bond);
    }

    [HttpPatch]
    [Route("[action]")]
    public async Task<IActionResult> UpdateBond(string _SecurityId, CRUDRequestBond crudRequestBond)
    {
        if (crudRequestBond == null) return NotFound();
        var _Bond = await _DBContext.Bonds.FindAsync(_SecurityId);
        if (_Bond != null)
        {
            _Bond.SecurityDescription = crudRequestBond.SecurityDescription;
            _Bond.SecurityName =crudRequestBond.SecurityName;
            _Bond.AssetType = crudRequestBond.AssetType;
            _Bond.InvestmentType = crudRequestBond.InvestmentType;
            _Bond.TradingFactor = crudRequestBond.TradingFactor;
            _Bond.PricingFactor = crudRequestBond.PricingFactor;
            _Bond.Isin = crudRequestBond.Isin;
            _Bond.BbgTicker = crudRequestBond.BbgTicker;
            _Bond.BbgUniqueId = crudRequestBond.BbgUniqueId;
            _Bond.Cusip = crudRequestBond.Cusip;
            _Bond.Sedol = crudRequestBond.Sedol;
            _Bond.FirstCouponDate = crudRequestBond.FirstCouponDate;
            _Bond.Cap = crudRequestBond.Cap;
            _Bond.Floor = crudRequestBond.Floor;
            _Bond.CouponFrequency = crudRequestBond.CouponFrequency;
            _Bond.Coupon = crudRequestBond.Coupon;
            _Bond.CouponType = crudRequestBond.CouponType;
            _Bond.Spread = crudRequestBond.Spread;
            _Bond.CallableFlag = crudRequestBond.CallableFlag;
            _Bond.FixToFloatFlag = crudRequestBond.FixToFloatFlag;
            _Bond.PutableFlag = crudRequestBond.PutableFlag;
            _Bond.IssueDate = crudRequestBond.IssueDate;
            _Bond.LastResetDate = crudRequestBond.LastResetDate;
            _Bond.Maturity = crudRequestBond.Maturity;
            _Bond.CallNotificationMaxDays = crudRequestBond.CallNotificationMaxDays;
            _Bond.PutNotificationMaxDays = crudRequestBond.PutNotificationMaxDays;
            _Bond.PenultimateCouponDate = crudRequestBond.PenultimateCouponDate;
            _Bond.ResetFrequency = crudRequestBond.ResetFrequency;
            _Bond.HasPosition = crudRequestBond.HasPosition;
            _Bond.MacaulayDuration = crudRequestBond.MacaulayDuration;
            _Bond._30dVolatility = crudRequestBond._30dVolatility;
            _Bond._90dVolatility = crudRequestBond._90dVolatility;
            _Bond.Convexity = crudRequestBond.Convexity;
            _Bond._30dayAverageVolume = crudRequestBond._30dayAverageVolume;
            _Bond.PfAssetClass = crudRequestBond.PfAssetClass;
            _Bond.PfCountry = crudRequestBond.PfCountry;
            _Bond.PfCreditRating = crudRequestBond.PfCreditRating;
            _Bond.PfCurrency = crudRequestBond.PfCurrency;
            _Bond.PfInstrument = crudRequestBond.PfInstrument;
            _Bond.PfLiquidityProfile = crudRequestBond.PfLiquidityProfile;
            _Bond.PfMaturity = crudRequestBond.PfMaturity;
            _Bond.PfNaicsCode = crudRequestBond.PfNaicsCode;
            _Bond.PfRegion = crudRequestBond.PfRegion;
            _Bond.PfSector = crudRequestBond.PfSector;
            _Bond.PfSubAssetClass = crudRequestBond.PfSubAssetClass;
            _Bond.BloombergIndustryGroup = crudRequestBond.BloombergIndustryGroup;
            _Bond.BloombergIndustrySubGroup = crudRequestBond.BloombergIndustrySubGroup;
            _Bond.BloombergIndustrySector = crudRequestBond.BloombergIndustrySector;
            _Bond.CountryOfIssuance = crudRequestBond.CountryOfIssuance;
            _Bond.IssueCurrency = crudRequestBond.IssueCurrency;
            _Bond.Issuer = crudRequestBond.Issuer;
            _Bond.RiskCurrency = crudRequestBond.RiskCurrency;
            _Bond.PutDate = crudRequestBond.PutDate;
            _Bond.PutPrice = crudRequestBond.PutPrice;
            _Bond.AskPrice = crudRequestBond.AskPrice;
            _Bond.HighPrice = crudRequestBond.HighPrice;
            _Bond.LowPrice = crudRequestBond.LowPrice;
            _Bond.OpenPrice = crudRequestBond.OpenPrice;
            _Bond.Volume = crudRequestBond.Volume;
            _Bond.BidPrice = crudRequestBond.BidPrice;
            _Bond.LastPrice = crudRequestBond.LastPrice;
            _Bond.CallDate = crudRequestBond.CallDate;
            _Bond.CallPrice = crudRequestBond.CallPrice;
            await _DBContext.SaveChangesAsync();
            return Ok(_Bond);
        };
        return NotFound();
    }

    [HttpDelete]
    [Route("[action]")]

    public async Task<IActionResult> DeleteSecurityByID(string _SecurityID)
    {
        var _Bonds = await _DBContext.Bonds.FindAsync(_SecurityID);
        if (_Bonds != null)
        { // hit delete operation in Databse and remove it from there.
            _DBContext.Remove(_Bonds);
            await _DBContext.SaveChangesAsync();
            return Ok(_Bonds); // delete succesful
        }
        return NotFound();// delete failed.
    }

}