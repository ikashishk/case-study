using System;
using System.Collections.Generic;

namespace case_study.Model
{
    public partial class Equity
    {
        public string SecurityId { get; set; } = null!;
        public string? SecurityName { get; set; }
        public string? SecurityDescription { get; set; }
        public bool? HasPosition { get; set; }
        public bool? IsActive { get; set; }
        public double? RoundLotSize { get; set; }
        public string? BloombergUniqueName { get; set; }
        public string? Cusip { get; set; }
        public string? Isin { get; set; }
        public string? Sedol { get; set; }
        public string? BloombergTicker { get; set; }
        public string? BloombergUniqueId { get; set; }
        public string? BloombergGlobalId { get; set; }
        public string? BloombergTickerAndExchange { get; set; }
        public bool? IsAdr { get; set; }
        public string? AdrunderlyingTicker { get; set; }
        public string? AdrunderlyingCurrency { get; set; }
        public double? SharesPerAdr { get; set; }
        public DateTime? Ipodate { get; set; }
        public string? PriceCurrency { get; set; }
        public int? SettleDays { get; set; }
        public double? TotalSharesOutstading { get; set; }
        public double? VotingRightsPerShare { get; set; }
        public double? AvgVolume20Days { get; set; }
        public double? Beta { get; set; }
        public double? ShortInterest { get; set; }
        public double? Ytdreturn { get; set; }
        public double? PriceVolatility90Days { get; set; }
        public string? PfassetClass { get; set; }
        public string? Pfcountry { get; set; }
        public string? PfcreditRating { get; set; }
        public string? Pfcurrency { get; set; }
        public string? Pfinstrument { get; set; }
        public string? PfliquidityProfile { get; set; }
        public string? Pfmaturity { get; set; }
        public string? Pfnaicscode { get; set; }
        public string? Pfregion { get; set; }
        public string? Pfsector { get; set; }
        public string? PfsubAssetClass { get; set; }
        public string? IssueCountry { get; set; }
        public string? Exchange { get; set; }
        public string? Issuer { get; set; }
        public string? IssueCurrency { get; set; }
        public string? TradingCurrency { get; set; }
        public string? BloombergIndustrySubGroup { get; set; }
        public string? BloombergIndustryGroup { get; set; }
        public string? BloombergIndustrySector { get; set; }
        public string? CountryOfIncorporation { get; set; }
        public string? RiskCurrency { get; set; }
        public double? OpenPrice { get; set; }
        public double? ClosePrice { get; set; }
        public double? Volume { get; set; }
        public double? LastPrice { get; set; }
        public double? AskPrice { get; set; }
        public double? BidPrice { get; set; }
        public double? Peratio { get; set; }
        public DateTime? DividendDeclaredDate { get; set; }
        public DateTime? DividendExDate { get; set; }
        public DateTime? DividendRecordDate { get; set; }
        public DateTime? DividendPayDate { get; set; }
        public double? DividendAmount { get; set; }
        public string? Frequency { get; set; }
        public string? DividendType { get; set; }
    }
}
