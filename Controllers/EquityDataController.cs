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
    [Route("[action]")]
    public async Task<IActionResult> GetSecurityByID(string _SecurityID)
    {
        var Equities = await _DBContext.Equities.FindAsync(_SecurityID);
        return Equities == null ? NotFound() : Ok(Equities);
    }

    [HttpPatch]
    [Route("[action]")]
    public async Task<IActionResult> UpdateEquity(string _SecurityId, CRUDRequestEquity crudRequestEquity)
    {
        var _Equity = await _DBContext.Equities.FindAsync(_SecurityId);
        if (_Equity != null)
        {
            // Sid = Convert.ToInt32(Guid.NewGuid()),
            _Equity.SecurityDescription = crudRequestEquity.SecurityDescription;
            _Equity.SecurityName = crudRequestEquity.SecurityName;
            _Equity.HasPosition = crudRequestEquity.HasPosition;
            _Equity.IsActiveSecurity = crudRequestEquity.IsActiveSecurity;
            _Equity.LotSize = crudRequestEquity.LotSize;
            _Equity.BbgUniqueName = crudRequestEquity.BbgUniqueName;
            _Equity.Cusip = crudRequestEquity.Cusip;
            _Equity.Isin = crudRequestEquity.Isin;
            _Equity.Sedol = crudRequestEquity.Sedol;
            _Equity.BloombergTicker = crudRequestEquity.BloombergTicker;
            _Equity.BloombergUniqueId = crudRequestEquity.BloombergUniqueId;
            _Equity.BbgGlobalId = crudRequestEquity.BbgGlobalId;
            _Equity.TickerAndExchange = crudRequestEquity.TickerAndExchange;
            _Equity.IsAdrFlag = crudRequestEquity.IsAdrFlag;
            _Equity.AdrUnderlyingTicker = crudRequestEquity.AdrUnderlyingTicker;
            _Equity.AdrUnderlyingCurrency = crudRequestEquity.AdrUnderlyingCurrency;
            _Equity.SharesPerAdr = crudRequestEquity.SharesPerAdr;
            _Equity.IpoDate = crudRequestEquity.IpoDate;
            _Equity.PricingCurrency = crudRequestEquity.PricingCurrency;
            _Equity.SettleDays = crudRequestEquity.SettleDays;
            _Equity.TotalSharesOutstanding = crudRequestEquity.TotalSharesOutstanding;
            _Equity.VotingRightsPerShare = crudRequestEquity.VotingRightsPerShare;
            _Equity.AverageVolume20d = crudRequestEquity.AverageVolume20d;
            _Equity.Beta = crudRequestEquity.Beta;
            _Equity.ShortInterest = crudRequestEquity.ShortInterest;
            _Equity.ReturnYtd = crudRequestEquity.ReturnYtd;
            _Equity.Volatility90d = crudRequestEquity.Volatility90d;
            _Equity.PfAssetClass = crudRequestEquity.PfAssetClass;
            _Equity.PfCountry = crudRequestEquity.PfCountry;
            _Equity.PfCreditRating = crudRequestEquity.PfCreditRating;
            _Equity.PfInstrument = crudRequestEquity.PfInstrument;
            _Equity.PfLiquidityProfile = crudRequestEquity.PfLiquidityProfile;
            _Equity.PfMaturity = crudRequestEquity.PfMaturity;
            _Equity.PfNaicsCode = crudRequestEquity.PfNaicsCode;
            _Equity.PfRegion = crudRequestEquity.PfRegion;
            _Equity.PfSector = crudRequestEquity.PfSector;
            _Equity.PfSubAssetClass = crudRequestEquity.PfSubAssetClass;
            _Equity.CountryOfIssuance = crudRequestEquity.CountryOfIssuance;
            _Equity.Exchange = crudRequestEquity.Exchange;
            _Equity.Issuer = crudRequestEquity.Issuer;
            _Equity.IssueCurrency = crudRequestEquity.IssueCurrency;
            _Equity.TradingCurrency = crudRequestEquity.TradingCurrency;
            _Equity.BbgIndustrySubGroup = crudRequestEquity.BbgIndustrySubGroup;
            _Equity.BloombergIndustryGroup = crudRequestEquity.BloombergIndustryGroup;
            _Equity.BloombergSector = crudRequestEquity.BloombergSector;
            _Equity.CountryOfIncorporation = crudRequestEquity.CountryOfIncorporation;
            _Equity.RiskCurrency = crudRequestEquity.RiskCurrency;
            _Equity.OpenPrice = crudRequestEquity.OpenPrice;
            _Equity.ClosePrice = crudRequestEquity.ClosePrice;
            _Equity.Volume = crudRequestEquity.Volume;
            _Equity.LastPrice = crudRequestEquity.LastPrice;
            _Equity.AskPrice = crudRequestEquity.AskPrice;
            _Equity.BidPrice = crudRequestEquity.BidPrice;
            _Equity.PeRatio = crudRequestEquity.PeRatio;
            _Equity.DividendDeclaredDate = crudRequestEquity.DividendDeclaredDate;
            _Equity.DividendExDate = crudRequestEquity.DividendExDate;
            _Equity.DividendRecordDate = crudRequestEquity.DividendRecordDate;
            _Equity.DividendPayDate = crudRequestEquity.DividendPayDate;
            _Equity.DividendAmount = crudRequestEquity.DividendAmount;
            _Equity.Frequency = crudRequestEquity.Frequency;
            _Equity.DividendType = crudRequestEquity.DividendType;
            // await _DBContext.Equities.AddAsync(_Equity);
            await _DBContext.SaveChangesAsync();
            return Ok(_Equity);
        }
        return NotFound();
        // if (_Equity == null) return NotFound();
    }


    ////////////////////////////







    //  create equity is still remaining





    //////////////////////
    [HttpPost]
    [Route("[action]")]
    public async Task<IActionResult> CreateEquity(CRUDRequestEquity crudRequestEquity)
    {
        if (crudRequestEquity == null) return NotFound();

        var _Equity = new Equity()
        {
            Sid = Guid.NewGuid().ToString(),
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
        await _DBContext.Equities.AddAsync(_Equity);
        await _DBContext.SaveChangesAsync();
        return Ok(_Equity);
    }

    [HttpDelete]
    [Route("[action]")]

    public async Task<IActionResult> DeleteSecurityByID(string _SecurityID)
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