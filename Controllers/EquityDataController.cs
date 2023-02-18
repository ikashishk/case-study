using case_study.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace case_study.Controllers;

[ApiController]
[Route("api/[controller]")]

public class EquityDataController : ControllerBase
{
    private readonly SecurityMaster_Group9Context _DBContext;

    public EquityDataController()
    {
        _DBContext = new SecurityMaster_Group9Context();
        _DBContext.Database.EnsureCreated();
    }

    [HttpGet("getAllEquities")]
    public async Task<IActionResult> GetAllEquities()
    {
        return Ok(await _DBContext.Equities.ToListAsync());
    }

    [HttpGet]
    public async Task<IActionResult> GetSecurityByID(int _SecurityID)
    {
        var Equities = await _DBContext.Equities.FindAsync(_SecurityID);
        return Equities == null ? NotFound() : Ok(Equities);
    }

    [HttpPost]
    [Route("[action]")]
    public async Task<IActionResult> addEquity(CRUDRequestEquity crudRequestEquity)
    {

        var _Equity = new Equity()
        {
            Sid = Convert.ToInt32(Guid.NewGuid()),
            SecurityDescription = crudRequestEquity.SecurityDescription,
            SecurityName = crudRequestEquity.SecurityName,
            HasPosition = crudRequestEquity.HasPosition,
            IsActiveSecurity = crudRequestEquity.IsActiveSecurity,
            LotSize = crudRequestEquity.LotSize,
            BbgUniqueName = crudRequestEquity.BbgUniqueName,
            Cusip = crudRequestEquity.Cusip,
            Isin = crudRequestEquity.Isin,
            Sedol = crudRequestEquity.Sedol,
            BloombergTicker = crudRequestEquity.BloombergTicker,
            BloombergUniqueId = crudRequestEquity.BloombergUniqueId,
            BbgGlobalId = crudRequestEquity.BbgGlobalId,
            TickerAndExchange = crudRequestEquity.TickerAndExchange,
            IsAdrFlag = crudRequestEquity.IsAdrFlag,
            AdrUnderlyingTicker = crudRequestEquity.AdrUnderlyingTicker,
            AdrUnderlyingCurrency = crudRequestEquity.AdrUnderlyingCurrency,
            SharesPerAdr = crudRequestEquity.SharesPerAdr,
            IpoDate = crudRequestEquity.IpoDate,
            PricingCurrency = crudRequestEquity.PricingCurrency,
            SettleDays = crudRequestEquity.SettleDays,
            TotalSharesOutstanding = crudRequestEquity.TotalSharesOutstanding,
            VotingRightsPerShare = crudRequestEquity.VotingRightsPerShare,
            AverageVolume20d = crudRequestEquity.AverageVolume20d,
            Beta = crudRequestEquity.Beta,
            ShortInterest = crudRequestEquity.ShortInterest,
            ReturnYtd = crudRequestEquity.ReturnYtd,
            Volatility90d = crudRequestEquity.Volatility90d,
            PfAssetClass = crudRequestEquity.PfAssetClass,
            PfCountry = crudRequestEquity.PfCountry,
            PfCreditRating = crudRequestEquity.PfCreditRating,
            PfCurrency = crudRequestEquity.PfCurrency,
            PfInstrument = crudRequestEquity.PfInstrument,
            PfLiquidityProfile = crudRequestEquity.PfLiquidityProfile,
            PfMaturity = crudRequestEquity.PfMaturity,
            PfNaicsCode = crudRequestEquity.PfNaicsCode,
            PfRegion = crudRequestEquity.PfRegion,
            PfSector = crudRequestEquity.PfSector,
            PfSubAssetClass = crudRequestEquity.PfSubAssetClass,
            CountryOfIssuance = crudRequestEquity.CountryOfIssuance,
            Exchange = crudRequestEquity.Exchange,
            Issuer = crudRequestEquity.Issuer,
            IssueCurrency = crudRequestEquity.IssueCurrency,
            TradingCurrency = crudRequestEquity.TradingCurrency,
            BbgIndustrySubGroup = crudRequestEquity.BbgIndustrySubGroup,
            BloombergIndustryGroup = crudRequestEquity.BloombergIndustryGroup,
            BloombergSector = crudRequestEquity.BloombergSector,
            CountryOfIncorporation = crudRequestEquity.CountryOfIncorporation,
            RiskCurrency = crudRequestEquity.RiskCurrency,
            OpenPrice = crudRequestEquity.OpenPrice,
            ClosePrice = crudRequestEquity.ClosePrice,
            Volume = crudRequestEquity.Volume,
            LastPrice = crudRequestEquity.LastPrice,
            AskPrice = crudRequestEquity.AskPrice,
            BidPrice = crudRequestEquity.BidPrice,
            PeRatio = crudRequestEquity.PeRatio,
            DividendDeclaredDate = crudRequestEquity.DividendDeclaredDate,
            DividendExDate = crudRequestEquity.DividendExDate,
            DividendRecordDate = crudRequestEquity.DividendRecordDate,
            DividendPayDate = crudRequestEquity.DividendPayDate,
            DividendAmount = crudRequestEquity.DividendAmount,
            Frequency = crudRequestEquity.Frequency,
            DividendType = crudRequestEquity.DividendType
        };
        // if (_Equity == null) return NotFound();
        await _DBContext.Equities.AddAsync(_Equity);
        await _DBContext.SaveChangesAsync();
        return Ok(_Equity);
    }

    [HttpDelete]
    [Route("[action]")]

    public async Task<IActionResult> DeleteSecurityByID(int _SecurityID)
    {
        var Equities = await _DBContext.Equities.FindAsync(_SecurityID);
        if (Equities != null)
        { // hit delete operation in Databse and remove it from there.
            _DBContext.Remove(Equities);
            await _DBContext.SaveChangesAsync();
            return Ok(Equities); // delete succesful
        }
        return NotFound();// delete failed.
    }
}