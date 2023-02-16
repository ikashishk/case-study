using System;
using System.Collections.Generic;

namespace case_study.Model
{
    public partial class Bond
    {
        public string SecurityId { get; set; } = null!;
        public string? SecurityName { get; set; }
        public string? SecurityDescription { get; set; }
        public string? AssetType { get; set; }
        public string? InvestmentType { get; set; }
        public double? TradingFactor { get; set; }
        public double? PricingFactor { get; set; }
        public string? Isin { get; set; }
        public string? BloombergTicker { get; set; }
        public string? BloombergUniqueId { get; set; }
        public string? Cusip { get; set; }
        public string? Sedol { get; set; }
        public DateTime? FirstCouponDate { get; set; }
        public double? CouponCap { get; set; }
        public double? CouponFloor { get; set; }
        public double? CouponFrequency { get; set; }
        public double? CouponRate { get; set; }
        public string? CouponType { get; set; }
        public double? FloatSpread { get; set; }
        public bool? IsCallable { get; set; }
        public bool? IsFixToFloat { get; set; }
        public bool? IsPutable { get; set; }
        public DateTime? IssueDate { get; set; }
        public DateTime? LastResetDate { get; set; }
        public DateTime? MaturityDate { get; set; }
        public double? MaxCallNoticeDays { get; set; }
        public double? MaxPutNoticeDays { get; set; }
        public DateTime? PenultimateCouponDate { get; set; }
        public double? ResetFrequency { get; set; }
        public bool? HasPosition { get; set; }
        public double? Duration { get; set; }
        public double? Volatility30Days { get; set; }
        public double? Volatility90Days { get; set; }
        public double? Convexity { get; set; }
        public double? AvgVolume30Days { get; set; }
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
        public string? BloombergIndustryGroup { get; set; }
        public string? BloombergIndustrySubGroup { get; set; }
        public string? BloombergIndustrySector { get; set; }
        public string? IssueCountry { get; set; }
        public string? IssueCurrency { get; set; }
        public string? Issuer { get; set; }
        public string? RiskCurrency { get; set; }
        public DateTime? PutDate { get; set; }
        public double? PutPrice { get; set; }
        public double? AskPrice { get; set; }
        public double? HighPrice { get; set; }
        public double? LowPrice { get; set; }
        public double? OpenPrice { get; set; }
        public double? Volume { get; set; }
        public double? BidPrice { get; set; }
        public double? LastPrice { get; set; }
        public DateTime? CallDate { get; set; }
        public double? CallPrice { get; set; }
    }
}
