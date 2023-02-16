﻿using System;
using System.Collections.Generic;

namespace case_study.Model
{
    public partial class AuditEquity
    {
        public int XnId { get; set; }
        public DateTime? XnDate { get; set; }
        public string? XnAction { get; set; }
        public string? Username { get; set; }
        public string? SecurityId { get; set; }
        public string? OldSecurityName { get; set; }
        public string? NewSecurityName { get; set; }
        public string? OldSecurityDescription { get; set; }
        public string? NewSecurityDescription { get; set; }
        public bool? OldHasPosition { get; set; }
        public bool? NewHasPosition { get; set; }
        public bool? OldIsActive { get; set; }
        public bool? NewIsActive { get; set; }
        public double? OldRoundLotSize { get; set; }
        public double? NewRoundLotSize { get; set; }
        public string? OldBloombergUniqueName { get; set; }
        public string? NewBloombergUniqueName { get; set; }
        public string? OldCusip { get; set; }
        public string? NewCusip { get; set; }
        public string? OldIsin { get; set; }
        public string? NewIsin { get; set; }
        public string? OldSedol { get; set; }
        public string? NewSedol { get; set; }
        public string? OldBloombergTicker { get; set; }
        public string? NewBloombergTicker { get; set; }
        public string? OldBloombergUniqueId { get; set; }
        public string? NewBloombergUniqueId { get; set; }
        public string? OldBloombergGlobalId { get; set; }
        public string? NewBloombergGlobalId { get; set; }
        public string? OldBloombergTickerAndExchange { get; set; }
        public string? NewBloombergTickerAndExchange { get; set; }
        public bool? OldIsAdr { get; set; }
        public bool? NewIsAdr { get; set; }
        public string? OldAdrunderlyingTicker { get; set; }
        public string? NewAdrunderlyingTicker { get; set; }
        public string? OldAdrunderlyingCurrency { get; set; }
        public string? NewAdrunderlyingCurrency { get; set; }
        public double? OldSharesPerAdr { get; set; }
        public double? NewSharesPerAdr { get; set; }
        public DateTime? OldIpodate { get; set; }
        public DateTime? NewIpodate { get; set; }
        public string? OldPriceCurrency { get; set; }
        public string? NewPriceCurrency { get; set; }
        public int? OldSettleDays { get; set; }
        public int? NewSettleDays { get; set; }
        public double? OldTotalSharesOutstading { get; set; }
        public double? NewTotalSharesOutstading { get; set; }
        public double? OldVotingRightsPerShare { get; set; }
        public double? NewVotingRightsPerShare { get; set; }
        public double? OldAvgVolume20Days { get; set; }
        public double? NewAvgVolume20Days { get; set; }
        public double? OldBeta { get; set; }
        public double? NewBeta { get; set; }
        public double? OldShortInterest { get; set; }
        public double? NewShortInterest { get; set; }
        public double? OldYtdreturn { get; set; }
        public double? NewYtdreturn { get; set; }
        public double? OldPriceVolatility90Days { get; set; }
        public double? NewPriceVolatility90Days { get; set; }
        public string? OldPfassetClass { get; set; }
        public string? NewPfassetClass { get; set; }
        public string? OldPfcountry { get; set; }
        public string? NewPfcountry { get; set; }
        public string? OldPfcreditRating { get; set; }
        public string? NewPfcreditRating { get; set; }
        public string? OldPfcurrency { get; set; }
        public string? NewPfcurrency { get; set; }
        public string? OldPfinstrument { get; set; }
        public string? NewPfinstrument { get; set; }
        public string? OldPfliquidityProfile { get; set; }
        public string? NewPfliquidityProfile { get; set; }
        public string? OldPfmaturity { get; set; }
        public string? NewPfmaturity { get; set; }
        public string? OldPfnaicscode { get; set; }
        public string? NewPfnaicscode { get; set; }
        public string? OldPfregion { get; set; }
        public string? NewPfregion { get; set; }
        public string? OldPfsector { get; set; }
        public string? NewPfsector { get; set; }
        public string? OldPfsubAssetClass { get; set; }
        public string? NewPfsubAssetClass { get; set; }
        public string? OldIssueCountry { get; set; }
        public string? NewIssueCountry { get; set; }
        public string? OldExchange { get; set; }
        public string? NewExchange { get; set; }
        public string? OldIssuer { get; set; }
        public string? NewIssuer { get; set; }
        public string? OldIssueCurrency { get; set; }
        public string? NewIssueCurrency { get; set; }
        public string? OldTradingCurrency { get; set; }
        public string? NewTradingCurrency { get; set; }
        public string? OldBloombergIndustrySubGroup { get; set; }
        public string? NewBloombergIndustrySubGroup { get; set; }
        public string? OldBloombergIndustryGroup { get; set; }
        public string? NewBloombergIndustryGroup { get; set; }
        public string? OldBloombergIndustrySector { get; set; }
        public string? NewBloombergIndustrySector { get; set; }
        public string? OldCountryOfIncorporation { get; set; }
        public string? NewCountryOfIncorporation { get; set; }
        public string? OldRiskCurrency { get; set; }
        public string? NewRiskCurrency { get; set; }
        public double? OldOpenPrice { get; set; }
        public double? NewOpenPrice { get; set; }
        public double? OldClosePrice { get; set; }
        public double? NewClosePrice { get; set; }
        public double? OldVolume { get; set; }
        public double? NewVolume { get; set; }
        public double? OldLastPrice { get; set; }
        public double? NewLastPrice { get; set; }
        public double? OldAskPrice { get; set; }
        public double? NewAskPrice { get; set; }
        public double? OldBidPrice { get; set; }
        public double? NewBidPrice { get; set; }
        public double? OldPeratio { get; set; }
        public double? NewPeratio { get; set; }
        public DateTime? OldDividendDeclaredDate { get; set; }
        public DateTime? NewDividendDeclaredDate { get; set; }
        public DateTime? OldDividendExDate { get; set; }
        public DateTime? NewDividendExDate { get; set; }
        public DateTime? OldDividendRecordDate { get; set; }
        public DateTime? NewDividendRecordDate { get; set; }
        public DateTime? OldDividendPayDate { get; set; }
        public DateTime? NewDividendPayDate { get; set; }
        public double? OldDividendAmount { get; set; }
        public double? NewDividendAmount { get; set; }
        public string? OldFrequency { get; set; }
        public string? NewFrequency { get; set; }
        public string? OldDividendType { get; set; }
        public string? NewDividendType { get; set; }
    }
}
