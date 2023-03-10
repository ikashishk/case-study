using System;
using System.Collections.Generic;

namespace case_study.Model
{
    public partial class AuditEquity
    {
        public string? Username { get; set; }
        public DateTime? Xndate { get; set; }
        public string? XnAction { get; set; }
        public string? SecurityId { get; set; }
        public string? OldSecurityName { get; set; }
        public string? NewSecurityName { get; set; }
        public string? OldSecurityDescription { get; set; }
        public string? NewSecurityDescription { get; set; }
        public string? OldHasPosistion { get; set; }
        public string? NewHasPosistion { get; set; }
        public string? OldIsActive { get; set; }
        public string? NewIsActive { get; set; }
        public double? OldRoundLotSize { get; set; }
        public double? NewRoundLotSize { get; set; }
        public string? OldBbguniqueName { get; set; }
        public string? NewBbguniqueName { get; set; }
        public string? OldCusip { get; set; }
        public string? NewCusip { get; set; }
        public string? OldIsin { get; set; }
        public string? NewIsin { get; set; }
        public string? OldSedol { get; set; }
        public string? NewSedol { get; set; }
        public string? OldBbgticker { get; set; }
        public string? NewBbgticker { get; set; }
        public string? OldBbguniqueId { get; set; }
        public string? NewBbguniqueId { get; set; }
        public string? OldBbgglobalId { get; set; }
        public string? NewBbgglobalId { get; set; }
        public string? OldBbgtickerExchange { get; set; }
        public string? NewBbgtickerExchange { get; set; }
        public string? OldIsAdr { get; set; }
        public string? NewIsAdr { get; set; }
        public string? OldAdrunderlyingTicker { get; set; }
        public string? NewAdrunderlyingTicker { get; set; }
        public string? OldAdrunderlyingCurrency { get; set; }
        public string? NewAdrunderlyingCurrency { get; set; }
        public string? OldSharesPerAdr { get; set; }
        public string? NewSharesPerAdr { get; set; }
        public string? OldIpodate { get; set; }
        public string? NewIpodate { get; set; }
        public string? OldPriceCurrency { get; set; }
        public string? NewPriceCurrency { get; set; }
        public int? OldSettleDays { get; set; }
        public int? NewSettleDays { get; set; }
        public double? OldSharesOutstading { get; set; }
        public double? NewSharesOutstading { get; set; }
        public string? OldVotingRightsPerShare { get; set; }
        public string? NewVotingRightsPerShare { get; set; }
        public string? OldTwentyDayAvgVol { get; set; }
        public string? NewTwentyDayAvgVol { get; set; }
        public string? OldBeta { get; set; }
        public string? NewBeta { get; set; }
        public string? OldShortInterest { get; set; }
        public string? NewShortInterest { get; set; }
        public string? OldYtdreturn { get; set; }
        public string? NewYtdreturn { get; set; }
        public double? OldNinetyDayPriceVolatility { get; set; }
        public double? NewNinetyDayPriceVolatility { get; set; }
        public string? OldFormPfassetClass { get; set; }
        public string? NewFormPfassetClass { get; set; }
        public string? OldFormPfcountry { get; set; }
        public string? NewFormPfcountry { get; set; }
        public string? OldFormPfcreditRating { get; set; }
        public string? NewFormPfcreditRating { get; set; }
        public string? OldFormPfcurrency { get; set; }
        public string? NewFormPfcurrency { get; set; }
        public string? OldFormPfinstrument { get; set; }
        public string? NewFormPfinstrument { get; set; }
        public string? OldFormPfliquidityProfile { get; set; }
        public string? NewFormPfliquidityProfile { get; set; }
        public string? OldFormPfmaturity { get; set; }
        public string? NewFormPfmaturity { get; set; }
        public string? OldFormPfnaicscode { get; set; }
        public string? NewFormPfnaicscode { get; set; }
        public string? OldFormPfregion { get; set; }
        public string? NewFormPfregion { get; set; }
        public string? OldFormPfsector { get; set; }
        public string? NewFormPfsector { get; set; }
        public string? OldFormPfsubAssetClass { get; set; }
        public string? NewFormPfsubAssetClass { get; set; }
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
        public string? OldBbgindustrySubGroup { get; set; }
        public string? NewBbgindustrySubGroup { get; set; }
        public string? OldBbgindustryGroup { get; set; }
        public string? NewBbgindustryGroup { get; set; }
        public string? OldBbgindustrySector { get; set; }
        public string? NewBbgindustrySector { get; set; }
        public string? OldIncorporationCountry { get; set; }
        public string? NewIncorporationCountry { get; set; }
        public string? OldRiskCurrency { get; set; }
        public string? NewRiskCurrency { get; set; }
        public double? OldOpenPrice { get; set; }
        public double? NewOpenPrice { get; set; }
        public double? OldClosePrice { get; set; }
        public double? NewClosePrice { get; set; }
        public string? OldVolume { get; set; }
        public string? NewVolume { get; set; }
        public double? OldLastPrice { get; set; }
        public double? NewLastPrice { get; set; }
        public double? OldAskPrice { get; set; }
        public double? NewAskPrice { get; set; }
        public double? OldBidPrice { get; set; }
        public double? NewBidPrice { get; set; }
        public double? OldPeratio { get; set; }
        public double? NewPeratio { get; set; }
        public DateTime? OldDeclaredDate { get; set; }
        public DateTime? NewDeclaredDate { get; set; }
        public DateTime? OldExdate { get; set; }
        public DateTime? NewExdate { get; set; }
        public DateTime? OldRecorddate { get; set; }
        public DateTime? NewRecorddate { get; set; }
        public DateTime? OldPaydate { get; set; }
        public DateTime? NewPaydate { get; set; }
        public double? OldAmount { get; set; }
        public double? NewAmount { get; set; }
        public string? OldFrequency { get; set; }
        public string? NewFrequency { get; set; }
        public string? OldDividendType { get; set; }
        public string? NewDividendType { get; set; }
    }
}
