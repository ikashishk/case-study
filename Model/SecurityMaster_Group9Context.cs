using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace case_study.Model
{
    public partial class SecurityMaster_Group9Context : DbContext
    {
        public SecurityMaster_Group9Context()
        {
        }

        public SecurityMaster_Group9Context(DbContextOptions<SecurityMaster_Group9Context> options)
            : base(options)
        {
        }

        public virtual DbSet<AuditBond> AuditBonds { get; set; } = null!;
        public virtual DbSet<AuditEquity> AuditEquities { get; set; } = null!;
        public virtual DbSet<Bond> Bonds { get; set; } = null!;
        public virtual DbSet<Equity> Equities { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
// #warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server = 192.168.0.13\\\\\\\\sqlexpress,58264; Database = SecurityMaster_Group9; User = sa; Password=sa@12345678");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AuditBond>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Audit_Bonds");

                entity.Property(e => e.BondId)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("Bond_id");

                entity.Property(e => e.NewAskPrice).HasColumnName("New_Ask_Price");

                entity.Property(e => e.NewAssetType)
                    .HasMaxLength(150)
                    .HasColumnName("New_Asset_Type");

                entity.Property(e => e.NewAvgVolume30days)
                    .HasMaxLength(150)
                    .HasColumnName("New_AvgVolume_30days");

                entity.Property(e => e.NewBbgIndustryGroup)
                    .HasMaxLength(50)
                    .HasColumnName("New_BBG_Industry_Group");

                entity.Property(e => e.NewBbgIndustrySector)
                    .HasMaxLength(50)
                    .HasColumnName("New_BBG_Industry_Sector");

                entity.Property(e => e.NewBbgIndustrySubGroup)
                    .HasMaxLength(50)
                    .HasColumnName("New_BBG_Industry_SubGroup");

                entity.Property(e => e.NewBbgTicker)
                    .HasMaxLength(150)
                    .HasColumnName("New_BBG_Ticker");

                entity.Property(e => e.NewBbgUniqueId)
                    .HasMaxLength(150)
                    .HasColumnName("New_BBG_UniqueID");

                entity.Property(e => e.NewBidPrice).HasColumnName("New_Bid_Price");

                entity.Property(e => e.NewCallDate)
                    .HasMaxLength(150)
                    .HasColumnName("New_CallDate");

                entity.Property(e => e.NewCallPrice).HasColumnName("New_CallPrice");

                entity.Property(e => e.NewConvexity).HasColumnName("New_Convexity");

                entity.Property(e => e.NewCouponCap)
                    .HasMaxLength(150)
                    .HasColumnName("New_Coupon_Cap");

                entity.Property(e => e.NewCouponFloor)
                    .HasMaxLength(150)
                    .HasColumnName("New_Coupon_Floor");

                entity.Property(e => e.NewCouponFrqeuency).HasColumnName("New_Coupon_frqeuency");

                entity.Property(e => e.NewCouponRate).HasColumnName("New_Coupon_Rate");

                entity.Property(e => e.NewCouponType)
                    .HasMaxLength(150)
                    .HasColumnName("New_Coupon_Type");

                entity.Property(e => e.NewCusip)
                    .HasMaxLength(150)
                    .HasColumnName("New_CUSIP");

                entity.Property(e => e.NewFirstCouponDate)
                    .HasMaxLength(150)
                    .HasColumnName("New_First_CouponDate");

                entity.Property(e => e.NewHasPosition)
                    .HasMaxLength(100)
                    .HasColumnName("New_Has_Position");

                entity.Property(e => e.NewHighPrice).HasColumnName("New_High_Price");

                entity.Property(e => e.NewInvestmentType)
                    .HasMaxLength(150)
                    .HasColumnName("New_Investment_Type");

                entity.Property(e => e.NewIsCallable)
                    .HasMaxLength(100)
                    .HasColumnName("New_IS_Callable");

                entity.Property(e => e.NewIsFixToFloat)
                    .HasMaxLength(100)
                    .HasColumnName("New_IsFixToFloat");

                entity.Property(e => e.NewIsPutable)
                    .HasMaxLength(100)
                    .HasColumnName("New_IsPutable");

                entity.Property(e => e.NewIsin)
                    .HasMaxLength(150)
                    .HasColumnName("New_ISIN");

                entity.Property(e => e.NewIssueCountry)
                    .HasMaxLength(50)
                    .HasColumnName("New_Issue_Country");

                entity.Property(e => e.NewIssueCurrency)
                    .HasMaxLength(50)
                    .HasColumnName("New_Issue_Currency");

                entity.Property(e => e.NewIssueDate)
                    .HasMaxLength(150)
                    .HasColumnName("New_IssueDate");

                entity.Property(e => e.NewIssuer)
                    .HasMaxLength(50)
                    .HasColumnName("New_Issuer");

                entity.Property(e => e.NewLastPrice).HasColumnName("New_Last_Price");

                entity.Property(e => e.NewLastResetDate)
                    .HasMaxLength(150)
                    .HasColumnName("New_LastResetDate");

                entity.Property(e => e.NewLowPrice).HasColumnName("New_Low_Price");

                entity.Property(e => e.NewMacaulayDuration).HasColumnName("New_Macaulay_Duration");

                entity.Property(e => e.NewMaturity)
                    .HasMaxLength(150)
                    .HasColumnName("New_Maturity");

                entity.Property(e => e.NewMaxCallNoticeDays).HasColumnName("New_MaxCallNoticeDays");

                entity.Property(e => e.NewMaxPutNoticeDays)
                    .HasMaxLength(150)
                    .HasColumnName("New_MaxPutNoticeDays");

                entity.Property(e => e.NewOpenPrice).HasColumnName("New_Open_Price");

                entity.Property(e => e.NewPenultimateCouponDate)
                    .HasMaxLength(150)
                    .HasColumnName("New_Penultimate_CouponDate");

                entity.Property(e => e.NewPfAssetClass)
                    .HasMaxLength(50)
                    .HasColumnName("New_PF_AssetClass");

                entity.Property(e => e.NewPfCountry)
                    .HasMaxLength(50)
                    .HasColumnName("New_PF_Country");

                entity.Property(e => e.NewPfCreditRating)
                    .HasMaxLength(50)
                    .HasColumnName("New_PF_CreditRating");

                entity.Property(e => e.NewPfCurrency)
                    .HasMaxLength(50)
                    .HasColumnName("New_PF_Currency");

                entity.Property(e => e.NewPfInstrument)
                    .HasMaxLength(50)
                    .HasColumnName("New_PF_Instrument");

                entity.Property(e => e.NewPfLiquidityProfile)
                    .HasMaxLength(50)
                    .HasColumnName("New_PF_LiquidityProfile");

                entity.Property(e => e.NewPfMaturity)
                    .HasMaxLength(150)
                    .HasColumnName("New_PF_Maturity");

                entity.Property(e => e.NewPfNaicsCode)
                    .HasMaxLength(150)
                    .HasColumnName("New_PF_NAICS_Code");

                entity.Property(e => e.NewPfRegion)
                    .HasMaxLength(50)
                    .HasColumnName("New_PF_Region");

                entity.Property(e => e.NewPfSector)
                    .HasMaxLength(150)
                    .HasColumnName("New_PF_Sector");

                entity.Property(e => e.NewPfSubAssetClass)
                    .HasMaxLength(150)
                    .HasColumnName("New_PF_SubAssetClass");

                entity.Property(e => e.NewPricingFactor).HasColumnName("New_Pricing_Factor");

                entity.Property(e => e.NewPutDate)
                    .HasMaxLength(150)
                    .HasColumnName("New_Put_Date");

                entity.Property(e => e.NewPutPrice)
                    .HasMaxLength(150)
                    .HasColumnName("New_Put_Price");

                entity.Property(e => e.NewResetFrequency)
                    .HasMaxLength(50)
                    .HasColumnName("New_ResetFrequency");

                entity.Property(e => e.NewRiskCurrency)
                    .HasMaxLength(50)
                    .HasColumnName("New_Risk_Currency");

                entity.Property(e => e.NewSecurityDescription)
                    .HasMaxLength(200)
                    .HasColumnName("New_Security_Description");

                entity.Property(e => e.NewSecurityName)
                    .HasMaxLength(50)
                    .HasColumnName("New_Security_Name");

                entity.Property(e => e.NewSedol)
                    .HasMaxLength(150)
                    .HasColumnName("New_SEDOL");

                entity.Property(e => e.NewSpread)
                    .HasMaxLength(150)
                    .HasColumnName("New_Spread");

                entity.Property(e => e.NewTradingFactor).HasColumnName("New_Trading_Factor");

                entity.Property(e => e.NewVolatility30days)
                    .HasMaxLength(150)
                    .HasColumnName("New_Volatility_30Days");

                entity.Property(e => e.NewVolatility90days)
                    .HasMaxLength(150)
                    .HasColumnName("New_Volatility_90Days");

                entity.Property(e => e.NewVolume).HasColumnName("New_Volume");

                entity.Property(e => e.OldAskPrice).HasColumnName("Old_Ask_Price");

                entity.Property(e => e.OldAssetType)
                    .HasMaxLength(150)
                    .HasColumnName("Old_Asset_Type");

                entity.Property(e => e.OldAvgVolume30days)
                    .HasMaxLength(150)
                    .HasColumnName("Old_AvgVolume_30days");

                entity.Property(e => e.OldBbgIndustryGroup)
                    .HasMaxLength(50)
                    .HasColumnName("Old_BBG_Industry_Group");

                entity.Property(e => e.OldBbgIndustrySector)
                    .HasMaxLength(50)
                    .HasColumnName("Old_BBG_Industry_Sector");

                entity.Property(e => e.OldBbgIndustrySubGroup)
                    .HasMaxLength(50)
                    .HasColumnName("Old_BBG_Industry_SubGroup");

                entity.Property(e => e.OldBbgTicker)
                    .HasMaxLength(150)
                    .HasColumnName("Old_BBG_Ticker");

                entity.Property(e => e.OldBbgUniqueId)
                    .HasMaxLength(150)
                    .HasColumnName("Old_BBG_UniqueID");

                entity.Property(e => e.OldBidPrice).HasColumnName("Old_Bid_Price");

                entity.Property(e => e.OldCallDate)
                    .HasMaxLength(150)
                    .HasColumnName("Old_CallDate");

                entity.Property(e => e.OldCallPrice).HasColumnName("Old_CallPrice");

                entity.Property(e => e.OldConvexity).HasColumnName("Old_Convexity");

                entity.Property(e => e.OldCouponCap)
                    .HasMaxLength(150)
                    .HasColumnName("Old_Coupon_Cap");

                entity.Property(e => e.OldCouponFloor)
                    .HasMaxLength(150)
                    .HasColumnName("Old_Coupon_Floor");

                entity.Property(e => e.OldCouponFrqeuency).HasColumnName("Old_Coupon_frqeuency");

                entity.Property(e => e.OldCouponRate).HasColumnName("Old_Coupon_Rate");

                entity.Property(e => e.OldCouponType)
                    .HasMaxLength(150)
                    .HasColumnName("Old_Coupon_Type");

                entity.Property(e => e.OldCusip)
                    .HasMaxLength(150)
                    .HasColumnName("Old_CUSIP");

                entity.Property(e => e.OldFirstCouponDate)
                    .HasMaxLength(150)
                    .HasColumnName("Old_First_CouponDate");

                entity.Property(e => e.OldFixToFloat)
                    .HasMaxLength(100)
                    .HasColumnName("Old_FixToFloat");

                entity.Property(e => e.OldHasPosition)
                    .HasMaxLength(100)
                    .HasColumnName("Old_Has_Position");

                entity.Property(e => e.OldHighPrice).HasColumnName("Old_High_Price");

                entity.Property(e => e.OldInvestmentType)
                    .HasMaxLength(150)
                    .HasColumnName("Old_Investment_Type");

                entity.Property(e => e.OldIsCallable)
                    .HasMaxLength(100)
                    .HasColumnName("Old_IS_Callable");

                entity.Property(e => e.OldIsPutable)
                    .HasMaxLength(100)
                    .HasColumnName("Old_IsPutable");

                entity.Property(e => e.OldIsin)
                    .HasMaxLength(150)
                    .HasColumnName("Old_ISIN");

                entity.Property(e => e.OldIssueCountry)
                    .HasMaxLength(50)
                    .HasColumnName("Old_Issue_Country");

                entity.Property(e => e.OldIssueCurrency)
                    .HasMaxLength(50)
                    .HasColumnName("Old_Issue_Currency");

                entity.Property(e => e.OldIssueDate)
                    .HasMaxLength(150)
                    .HasColumnName("Old_IssueDate");

                entity.Property(e => e.OldIssuer)
                    .HasMaxLength(50)
                    .HasColumnName("Old_Issuer");

                entity.Property(e => e.OldLastPrice).HasColumnName("Old_Last_Price");

                entity.Property(e => e.OldLastResetDate)
                    .HasMaxLength(150)
                    .HasColumnName("Old_LastResetDate");

                entity.Property(e => e.OldLowPrice).HasColumnName("Old_Low_Price");

                entity.Property(e => e.OldMacaulayDuration).HasColumnName("Old_Macaulay_Duration");

                entity.Property(e => e.OldMaturity)
                    .HasMaxLength(150)
                    .HasColumnName("Old_Maturity");

                entity.Property(e => e.OldMaxCallNoticeDays).HasColumnName("Old_MaxCallNoticeDays");

                entity.Property(e => e.OldMaxPutNoticeDays)
                    .HasMaxLength(150)
                    .HasColumnName("Old_MaxPutNoticeDays");

                entity.Property(e => e.OldOpenPrice).HasColumnName("Old_Open_Price");

                entity.Property(e => e.OldPenultimateCouponDate)
                    .HasMaxLength(150)
                    .HasColumnName("Old_Penultimate_CouponDate");

                entity.Property(e => e.OldPfAssetClass)
                    .HasMaxLength(50)
                    .HasColumnName("Old_PF_AssetClass");

                entity.Property(e => e.OldPfCountry)
                    .HasMaxLength(50)
                    .HasColumnName("Old_PF_Country");

                entity.Property(e => e.OldPfCreditRating)
                    .HasMaxLength(50)
                    .HasColumnName("Old_PF_CreditRating");

                entity.Property(e => e.OldPfCurrency)
                    .HasMaxLength(50)
                    .HasColumnName("Old_PF_Currency");

                entity.Property(e => e.OldPfInstrument)
                    .HasMaxLength(50)
                    .HasColumnName("Old_PF_Instrument");

                entity.Property(e => e.OldPfLiquidityProfile)
                    .HasMaxLength(50)
                    .HasColumnName("Old_PF_LiquidityProfile");

                entity.Property(e => e.OldPfMaturity)
                    .HasMaxLength(150)
                    .HasColumnName("Old_PF_Maturity");

                entity.Property(e => e.OldPfNaicsCode)
                    .HasMaxLength(150)
                    .HasColumnName("Old_PF_NAICS_Code");

                entity.Property(e => e.OldPfRegion)
                    .HasMaxLength(50)
                    .HasColumnName("Old_PF_Region");

                entity.Property(e => e.OldPfSector)
                    .HasMaxLength(150)
                    .HasColumnName("Old_PF_Sector");

                entity.Property(e => e.OldPfSubAssetClass)
                    .HasMaxLength(150)
                    .HasColumnName("Old_PF_SubAssetClass");

                entity.Property(e => e.OldPricingFactor).HasColumnName("Old_Pricing_Factor");

                entity.Property(e => e.OldPutDate)
                    .HasMaxLength(150)
                    .HasColumnName("Old_Put_Date");

                entity.Property(e => e.OldPutPrice)
                    .HasMaxLength(150)
                    .HasColumnName("Old_Put_Price");

                entity.Property(e => e.OldResetFrequency)
                    .HasMaxLength(50)
                    .HasColumnName("Old_ResetFrequency");

                entity.Property(e => e.OldRiskCurrency)
                    .HasMaxLength(50)
                    .HasColumnName("Old_Risk_Currency");

                entity.Property(e => e.OldSecurityDescription)
                    .HasMaxLength(200)
                    .HasColumnName("Old_Security_Description");

                entity.Property(e => e.OldSecurityName)
                    .HasMaxLength(50)
                    .HasColumnName("Old_Security_Name");

                entity.Property(e => e.OldSedol)
                    .HasMaxLength(150)
                    .HasColumnName("Old_SEDOL");

                entity.Property(e => e.OldSpread)
                    .HasMaxLength(150)
                    .HasColumnName("Old_Spread");

                entity.Property(e => e.OldTradingFactor).HasColumnName("Old_Trading_Factor");

                entity.Property(e => e.OldVolatility30days)
                    .HasMaxLength(150)
                    .HasColumnName("Old_Volatility_30Days");

                entity.Property(e => e.OldVolatility90days)
                    .HasMaxLength(150)
                    .HasColumnName("Old_Volatility_90Days");

                entity.Property(e => e.OldVolume).HasColumnName("Old_Volume");

                entity.Property(e => e.Username)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.XnAction)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Xndate).HasColumnType("datetime");
            });

            modelBuilder.Entity<AuditEquity>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Audit_Equity");

                entity.Property(e => e.NewAdrunderlyingCurrency)
                    .HasMaxLength(125)
                    .IsUnicode(false)
                    .HasColumnName("NewADRUnderlyingCurrency");

                entity.Property(e => e.NewAdrunderlyingTicker)
                    .HasMaxLength(125)
                    .HasColumnName("NewADRUnderlyingTicker");

                entity.Property(e => e.NewBbgglobalId)
                    .HasMaxLength(150)
                    .HasColumnName("NewBBGGlobalID");

                entity.Property(e => e.NewBbgindustryGroup)
                    .HasMaxLength(150)
                    .HasColumnName("NewBBGIndustryGroup");

                entity.Property(e => e.NewBbgindustrySector)
                    .HasMaxLength(150)
                    .HasColumnName("NewBBGIndustrySector");

                entity.Property(e => e.NewBbgindustrySubGroup)
                    .HasMaxLength(150)
                    .HasColumnName("NewBBGIndustrySubGroup");

                entity.Property(e => e.NewBbgticker)
                    .HasMaxLength(150)
                    .HasColumnName("NewBBGTicker");

                entity.Property(e => e.NewBbgtickerExchange)
                    .HasMaxLength(150)
                    .HasColumnName("NewBBGTickerExchange");

                entity.Property(e => e.NewBbguniqueId)
                    .HasMaxLength(150)
                    .HasColumnName("NewBBGUniqueID");

                entity.Property(e => e.NewBbguniqueName)
                    .HasMaxLength(150)
                    .HasColumnName("NewBBGUniqueName");

                entity.Property(e => e.NewBeta).HasMaxLength(150);

                entity.Property(e => e.NewCusip)
                    .HasMaxLength(150)
                    .HasColumnName("NewCUSIP");

                entity.Property(e => e.NewDividendType).HasMaxLength(130);

                entity.Property(e => e.NewExchange).HasMaxLength(160);

                entity.Property(e => e.NewFormPfassetClass)
                    .HasMaxLength(110)
                    .HasColumnName("NewFormPFAssetClass");

                entity.Property(e => e.NewFormPfcountry)
                    .HasMaxLength(150)
                    .HasColumnName("NewFormPFCountry");

                entity.Property(e => e.NewFormPfcreditRating)
                    .HasMaxLength(120)
                    .HasColumnName("NewFormPFCreditRating");

                entity.Property(e => e.NewFormPfcurrency)
                    .HasMaxLength(150)
                    .HasColumnName("NewFormPFCurrency");

                entity.Property(e => e.NewFormPfinstrument)
                    .HasMaxLength(120)
                    .HasColumnName("NewFormPFInstrument");

                entity.Property(e => e.NewFormPfliquidityProfile)
                    .HasMaxLength(130)
                    .HasColumnName("NewFormPFLiquidityProfile");

                entity.Property(e => e.NewFormPfmaturity)
                    .HasMaxLength(120)
                    .HasColumnName("NewFormPFMaturity");

                entity.Property(e => e.NewFormPfnaicscode)
                    .HasMaxLength(150)
                    .HasColumnName("NewFormPFNAICSCode");

                entity.Property(e => e.NewFormPfregion)
                    .HasMaxLength(100)
                    .HasColumnName("NewFormPFRegion");

                entity.Property(e => e.NewFormPfsector)
                    .HasMaxLength(150)
                    .HasColumnName("NewFormPFSector");

                entity.Property(e => e.NewFormPfsubAssetClass)
                    .HasMaxLength(150)
                    .HasColumnName("NewFormPFSubAssetClass");

                entity.Property(e => e.NewFrequency).HasMaxLength(120);

                entity.Property(e => e.NewHasPosistion).HasMaxLength(100);

                entity.Property(e => e.NewIncorporationCountry).HasMaxLength(150);

                entity.Property(e => e.NewIpodate)
                    .HasMaxLength(100)
                    .HasColumnName("NewIPODate");

                entity.Property(e => e.NewIsActive).HasMaxLength(100);

                entity.Property(e => e.NewIsAdr)
                    .HasMaxLength(100)
                    .HasColumnName("NewIsADR");

                entity.Property(e => e.NewIsin)
                    .HasMaxLength(150)
                    .HasColumnName("NewISIN");

                entity.Property(e => e.NewIssueCountry).HasMaxLength(150);

                entity.Property(e => e.NewIssueCurrency).HasMaxLength(110);

                entity.Property(e => e.NewIssuer).HasMaxLength(150);

                entity.Property(e => e.NewPeratio).HasColumnName("NewPERatio");

                entity.Property(e => e.NewPriceCurrency).HasMaxLength(110);

                entity.Property(e => e.NewRiskCurrency).HasMaxLength(110);

                entity.Property(e => e.NewSecurityDescription).HasMaxLength(200);

                entity.Property(e => e.NewSecurityName).HasMaxLength(150);

                entity.Property(e => e.NewSedol)
                    .HasMaxLength(150)
                    .HasColumnName("NewSEDOL");

                entity.Property(e => e.NewSharesPerAdr)
                    .HasMaxLength(125)
                    .HasColumnName("NewSharesPerADR");

                entity.Property(e => e.NewShortInterest).HasMaxLength(150);

                entity.Property(e => e.NewTradingCurrency).HasMaxLength(110);

                entity.Property(e => e.NewTwentyDayAvgVol).HasMaxLength(150);

                entity.Property(e => e.NewVolume).HasMaxLength(100);

                entity.Property(e => e.NewVotingRightsPerShare).HasMaxLength(150);

                entity.Property(e => e.NewYtdreturn)
                    .HasMaxLength(150)
                    .HasColumnName("NewYTDReturn");

                entity.Property(e => e.OldAdrunderlyingCurrency)
                    .HasMaxLength(125)
                    .IsUnicode(false)
                    .HasColumnName("OldADRUnderlyingCurrency");

                entity.Property(e => e.OldAdrunderlyingTicker)
                    .HasMaxLength(125)
                    .HasColumnName("OldADRUnderlyingTicker");

                entity.Property(e => e.OldBbgglobalId)
                    .HasMaxLength(150)
                    .HasColumnName("OldBBGGlobalID");

                entity.Property(e => e.OldBbgindustryGroup)
                    .HasMaxLength(150)
                    .HasColumnName("OldBBGIndustryGroup");

                entity.Property(e => e.OldBbgindustrySector)
                    .HasMaxLength(150)
                    .HasColumnName("OldBBGIndustrySector");

                entity.Property(e => e.OldBbgindustrySubGroup)
                    .HasMaxLength(150)
                    .HasColumnName("OldBBGIndustrySubGroup");

                entity.Property(e => e.OldBbgticker)
                    .HasMaxLength(150)
                    .HasColumnName("OldBBGTicker");

                entity.Property(e => e.OldBbgtickerExchange)
                    .HasMaxLength(150)
                    .HasColumnName("OldBBGTickerExchange");

                entity.Property(e => e.OldBbguniqueId)
                    .HasMaxLength(150)
                    .HasColumnName("OldBBGUniqueID");

                entity.Property(e => e.OldBbguniqueName)
                    .HasMaxLength(150)
                    .HasColumnName("OldBBGUniqueName");

                entity.Property(e => e.OldBeta).HasMaxLength(150);

                entity.Property(e => e.OldCusip)
                    .HasMaxLength(150)
                    .HasColumnName("OldCUSIP");

                entity.Property(e => e.OldDividendType).HasMaxLength(130);

                entity.Property(e => e.OldExchange).HasMaxLength(160);

                entity.Property(e => e.OldFormPfassetClass)
                    .HasMaxLength(110)
                    .HasColumnName("OldFormPFAssetClass");

                entity.Property(e => e.OldFormPfcountry)
                    .HasMaxLength(150)
                    .HasColumnName("OldFormPFCountry");

                entity.Property(e => e.OldFormPfcreditRating)
                    .HasMaxLength(120)
                    .HasColumnName("OldFormPFCreditRating");

                entity.Property(e => e.OldFormPfcurrency)
                    .HasMaxLength(150)
                    .HasColumnName("OldFormPFCurrency");

                entity.Property(e => e.OldFormPfinstrument)
                    .HasMaxLength(120)
                    .HasColumnName("OldFormPFInstrument");

                entity.Property(e => e.OldFormPfliquidityProfile)
                    .HasMaxLength(130)
                    .HasColumnName("OldFormPFLiquidityProfile");

                entity.Property(e => e.OldFormPfmaturity)
                    .HasMaxLength(120)
                    .HasColumnName("OldFormPFMaturity");

                entity.Property(e => e.OldFormPfnaicscode)
                    .HasMaxLength(150)
                    .HasColumnName("OldFormPFNAICSCode");

                entity.Property(e => e.OldFormPfregion)
                    .HasMaxLength(100)
                    .HasColumnName("OldFormPFRegion");

                entity.Property(e => e.OldFormPfsector)
                    .HasMaxLength(150)
                    .HasColumnName("OldFormPFSector");

                entity.Property(e => e.OldFormPfsubAssetClass)
                    .HasMaxLength(150)
                    .HasColumnName("OldFormPFSubAssetClass");

                entity.Property(e => e.OldFrequency).HasMaxLength(120);

                entity.Property(e => e.OldHasPosistion).HasMaxLength(100);

                entity.Property(e => e.OldIncorporationCountry).HasMaxLength(150);

                entity.Property(e => e.OldIpodate)
                    .HasMaxLength(100)
                    .HasColumnName("OldIPODate");

                entity.Property(e => e.OldIsActive).HasMaxLength(100);

                entity.Property(e => e.OldIsAdr)
                    .HasMaxLength(100)
                    .HasColumnName("OldIsADR");

                entity.Property(e => e.OldIsin)
                    .HasMaxLength(150)
                    .HasColumnName("OldISIN");

                entity.Property(e => e.OldIssueCountry).HasMaxLength(150);

                entity.Property(e => e.OldIssueCurrency).HasMaxLength(110);

                entity.Property(e => e.OldIssuer).HasMaxLength(150);

                entity.Property(e => e.OldPeratio).HasColumnName("OldPERatio");

                entity.Property(e => e.OldPriceCurrency).HasMaxLength(110);

                entity.Property(e => e.OldRiskCurrency).HasMaxLength(110);

                entity.Property(e => e.OldSecurityDescription).HasMaxLength(200);

                entity.Property(e => e.OldSecurityName).HasMaxLength(150);

                entity.Property(e => e.OldSedol)
                    .HasMaxLength(150)
                    .HasColumnName("OldSEDOL");

                entity.Property(e => e.OldSharesPerAdr)
                    .HasMaxLength(125)
                    .HasColumnName("OldSharesPerADR");

                entity.Property(e => e.OldShortInterest).HasMaxLength(150);

                entity.Property(e => e.OldTradingCurrency).HasMaxLength(110);

                entity.Property(e => e.OldTwentyDayAvgVol).HasMaxLength(150);

                entity.Property(e => e.OldVolume).HasMaxLength(100);

                entity.Property(e => e.OldVotingRightsPerShare).HasMaxLength(150);

                entity.Property(e => e.OldYtdreturn)
                    .HasMaxLength(150)
                    .HasColumnName("OldYTDReturn");

                entity.Property(e => e.SecurityId)
                    .HasMaxLength(100)
                    .HasColumnName("SecurityID");

                entity.Property(e => e.Username)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.XnAction)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Xndate).HasColumnType("datetime");
            });

            modelBuilder.Entity<Bond>(entity =>
            {
                entity.HasKey(e => e.Bid)
                    .HasName("PK__Bond__C6DE0D2117D23ABE");

                entity.ToTable("Bond");

                entity.Property(e => e.Bid)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("BID");

                entity.Property(e => e.AskPrice).HasColumnName("Ask_Price");

                entity.Property(e => e.AssetType)
                    .HasMaxLength(50)
                    .HasColumnName("Asset_Type");

                entity.Property(e => e.BbgTicker)
                    .HasMaxLength(50)
                    .HasColumnName("BBG_Ticker");

                entity.Property(e => e.BbgUniqueId)
                    .HasMaxLength(50)
                    .HasColumnName("BBG_Unique_ID");

                entity.Property(e => e.BidPrice).HasColumnName("Bid_Price");

                entity.Property(e => e.BloombergIndustryGroup)
                    .HasMaxLength(50)
                    .HasColumnName("Bloomberg_Industry_Group");

                entity.Property(e => e.BloombergIndustrySector)
                    .HasMaxLength(50)
                    .HasColumnName("Bloomberg_Industry_Sector");

                entity.Property(e => e.BloombergIndustrySubGroup)
                    .HasMaxLength(50)
                    .HasColumnName("Bloomberg_Industry_Sub_Group");

                entity.Property(e => e.CallDate)
                    .HasMaxLength(150)
                    .HasColumnName("Call_Date");

                entity.Property(e => e.CallNotificationMaxDays).HasColumnName("Call_Notification_Max_Days");

                entity.Property(e => e.CallPrice).HasColumnName("Call_Price");

                entity.Property(e => e.CallableFlag)
                    .HasMaxLength(100)
                    .HasColumnName("Callable_Flag");

                entity.Property(e => e.Cap).HasMaxLength(100);

                entity.Property(e => e.CountryOfIssuance)
                    .HasMaxLength(50)
                    .HasColumnName("Country_of_Issuance");

                entity.Property(e => e.CouponFrequency).HasColumnName("Coupon_Frequency");

                entity.Property(e => e.CouponType)
                    .HasMaxLength(50)
                    .HasColumnName("Coupon_Type");

                entity.Property(e => e.Cusip)
                    .HasMaxLength(50)
                    .HasColumnName("CUSIP");

                entity.Property(e => e.FirstCouponDate)
                    .HasMaxLength(150)
                    .HasColumnName("First_Coupon_Date");

                entity.Property(e => e.FixToFloatFlag)
                    .HasMaxLength(100)
                    .HasColumnName("Fix_to_Float_Flag");

                entity.Property(e => e.Floor).HasMaxLength(100);

                entity.Property(e => e.HasPosition)
                    .HasMaxLength(100)
                    .HasColumnName("Has_Position");

                entity.Property(e => e.HighPrice).HasColumnName("High_Price");

                entity.Property(e => e.InvestmentType)
                    .HasMaxLength(50)
                    .HasColumnName("Investment_Type");

                entity.Property(e => e.Isin)
                    .HasMaxLength(100)
                    .HasColumnName("ISIN");

                entity.Property(e => e.IssueCurrency)
                    .HasMaxLength(50)
                    .HasColumnName("Issue_Currency");

                entity.Property(e => e.IssueDate)
                    .HasMaxLength(150)
                    .HasColumnName("Issue_Date");

                entity.Property(e => e.Issuer).HasMaxLength(50);

                entity.Property(e => e.LastPrice).HasColumnName("Last_Price");

                entity.Property(e => e.LastResetDate)
                    .HasMaxLength(100)
                    .HasColumnName("Last_Reset_Date");

                entity.Property(e => e.LowPrice).HasColumnName("Low_Price");

                entity.Property(e => e.MacaulayDuration).HasColumnName("Macaulay_Duration");

                entity.Property(e => e.Maturity).HasMaxLength(150);

                entity.Property(e => e.OpenPrice).HasColumnName("Open_Price");

                entity.Property(e => e.PenultimateCouponDate)
                    .HasMaxLength(150)
                    .HasColumnName("Penultimate_Coupon_Date");

                entity.Property(e => e.PfAssetClass)
                    .HasMaxLength(50)
                    .HasColumnName("PF_Asset_Class");

                entity.Property(e => e.PfCountry)
                    .HasMaxLength(50)
                    .HasColumnName("PF_Country");

                entity.Property(e => e.PfCreditRating)
                    .HasMaxLength(50)
                    .HasColumnName("PF_Credit_Rating");

                entity.Property(e => e.PfCurrency)
                    .HasMaxLength(50)
                    .HasColumnName("PF_Currency");

                entity.Property(e => e.PfInstrument)
                    .HasMaxLength(50)
                    .HasColumnName("PF_Instrument");

                entity.Property(e => e.PfLiquidityProfile)
                    .HasMaxLength(50)
                    .HasColumnName("PF_Liquidity_Profile");

                entity.Property(e => e.PfMaturity)
                    .HasMaxLength(100)
                    .HasColumnName("PF_Maturity");

                entity.Property(e => e.PfNaicsCode)
                    .HasMaxLength(100)
                    .HasColumnName("PF_NAICS_Code");

                entity.Property(e => e.PfRegion)
                    .HasMaxLength(50)
                    .HasColumnName("PF_Region");

                entity.Property(e => e.PfSector)
                    .HasMaxLength(100)
                    .HasColumnName("PF_Sector");

                entity.Property(e => e.PfSubAssetClass)
                    .HasMaxLength(100)
                    .HasColumnName("PF_Sub_Asset_Class");

                entity.Property(e => e.PricingFactor).HasColumnName("Pricing_Factor");

                entity.Property(e => e.PutDate)
                    .HasMaxLength(100)
                    .HasColumnName("Put_Date");

                entity.Property(e => e.PutNotificationMaxDays)
                    .HasMaxLength(100)
                    .HasColumnName("Put_Notification_Max_Days");

                entity.Property(e => e.PutPrice)
                    .HasMaxLength(100)
                    .HasColumnName("Put_Price");

                entity.Property(e => e.PutableFlag)
                    .HasMaxLength(100)
                    .HasColumnName("Putable_Flag");

                entity.Property(e => e.ResetFrequency)
                    .HasMaxLength(100)
                    .HasColumnName("Reset_Frequency");

                entity.Property(e => e.RiskCurrency)
                    .HasMaxLength(50)
                    .HasColumnName("Risk_Currency");

                entity.Property(e => e.SecurityDescription)
                    .HasMaxLength(200)
                    .HasColumnName("Security_Description");

                entity.Property(e => e.SecurityName)
                    .HasMaxLength(50)
                    .HasColumnName("Security_Name");

                entity.Property(e => e.Sedol)
                    .HasMaxLength(50)
                    .HasColumnName("SEDOL");

                entity.Property(e => e.Spread).HasMaxLength(100);

                entity.Property(e => e.TradingFactor).HasColumnName("Trading_Factor");

                entity.Property(e => e._30dVolatility)
                    .HasMaxLength(50)
                    .HasColumnName("_30D_Volatility");

                entity.Property(e => e._30dayAverageVolume)
                    .HasMaxLength(50)
                    .HasColumnName("_30Day_Average_Volume");

                entity.Property(e => e._90dVolatility)
                    .HasMaxLength(50)
                    .HasColumnName("_90D_Volatility");
            });

            modelBuilder.Entity<Equity>(entity =>
            {
                entity.HasKey(e => e.Sid)
                    .HasName("PK__Equity__CA195970751E1DB2");

                entity.ToTable("Equity");

                entity.Property(e => e.Sid)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("SID");

                entity.Property(e => e.AdrUnderlyingCurrency)
                    .HasMaxLength(50)
                    .HasColumnName("ADR_Underlying_Currency");

                entity.Property(e => e.AdrUnderlyingTicker)
                    .HasMaxLength(100)
                    .HasColumnName("ADR_Underlying_Ticker");

                entity.Property(e => e.AskPrice).HasColumnName("Ask_Price");

                entity.Property(e => e.AverageVolume20d)
                    .HasMaxLength(50)
                    .HasColumnName("Average_Volume_20D");

                entity.Property(e => e.BbgGlobalId)
                    .HasMaxLength(50)
                    .HasColumnName("BBG_Global_ID");

                entity.Property(e => e.BbgIndustrySubGroup)
                    .HasMaxLength(50)
                    .HasColumnName("BBG_Industry_Sub_Group");

                entity.Property(e => e.BbgUniqueName)
                    .HasMaxLength(50)
                    .HasColumnName("BBG_Unique_Name");

                entity.Property(e => e.Beta).HasMaxLength(50);

                entity.Property(e => e.BidPrice).HasColumnName("Bid_Price");

                entity.Property(e => e.BloombergIndustryGroup)
                    .HasMaxLength(50)
                    .HasColumnName("Bloomberg_Industry_Group");

                entity.Property(e => e.BloombergSector)
                    .HasMaxLength(50)
                    .HasColumnName("Bloomberg_Sector");

                entity.Property(e => e.BloombergTicker)
                    .HasMaxLength(50)
                    .HasColumnName("Bloomberg_Ticker");

                entity.Property(e => e.BloombergUniqueId)
                    .HasMaxLength(50)
                    .HasColumnName("Bloomberg_Unique_ID");

                entity.Property(e => e.ClosePrice).HasColumnName("Close_Price");

                entity.Property(e => e.CountryOfIncorporation)
                    .HasMaxLength(50)
                    .HasColumnName("Country_of_Incorporation");

                entity.Property(e => e.CountryOfIssuance)
                    .HasMaxLength(50)
                    .HasColumnName("Country_of_Issuance");

                entity.Property(e => e.Cusip)
                    .HasMaxLength(50)
                    .HasColumnName("CUSIP");

                entity.Property(e => e.DividendAmount).HasColumnName("Dividend_Amount");

                entity.Property(e => e.DividendDeclaredDate).HasColumnName("Dividend_Declared_Date");

                entity.Property(e => e.DividendExDate).HasColumnName("Dividend_Ex_Date");

                entity.Property(e => e.DividendPayDate).HasColumnName("Dividend_Pay_Date");

                entity.Property(e => e.DividendRecordDate).HasColumnName("Dividend_Record_Date");

                entity.Property(e => e.DividendType)
                    .HasMaxLength(50)
                    .HasColumnName("Dividend_Type");

                entity.Property(e => e.Exchange).HasMaxLength(50);

                entity.Property(e => e.Frequency).HasMaxLength(150);

                entity.Property(e => e.HasPosition)
                    .HasMaxLength(50)
                    .HasColumnName("Has_Position");

                entity.Property(e => e.IpoDate)
                    .HasMaxLength(50)
                    .HasColumnName("IPO_Date");

                entity.Property(e => e.IsActiveSecurity)
                    .HasMaxLength(50)
                    .HasColumnName("Is_Active_Security");

                entity.Property(e => e.IsAdrFlag)
                    .HasMaxLength(50)
                    .HasColumnName("Is_ADR_Flag");

                entity.Property(e => e.Isin)
                    .HasMaxLength(50)
                    .HasColumnName("ISIN");

                entity.Property(e => e.IssueCurrency)
                    .HasMaxLength(50)
                    .HasColumnName("Issue_Currency");

                entity.Property(e => e.Issuer).HasMaxLength(50);

                entity.Property(e => e.LastPrice).HasColumnName("Last_Price");

                entity.Property(e => e.LotSize).HasColumnName("Lot_Size");

                entity.Property(e => e.OpenPrice).HasColumnName("Open_Price");

                entity.Property(e => e.PeRatio).HasColumnName("PE_Ratio");

                entity.Property(e => e.PfAssetClass)
                    .HasMaxLength(50)
                    .HasColumnName("PF_Asset_Class");

                entity.Property(e => e.PfCountry)
                    .HasMaxLength(50)
                    .HasColumnName("PF_Country");

                entity.Property(e => e.PfCreditRating)
                    .HasMaxLength(50)
                    .HasColumnName("PF_Credit_Rating");

                entity.Property(e => e.PfCurrency)
                    .HasMaxLength(50)
                    .HasColumnName("PF_Currency");

                entity.Property(e => e.PfInstrument)
                    .HasMaxLength(50)
                    .HasColumnName("PF_Instrument");

                entity.Property(e => e.PfLiquidityProfile)
                    .HasMaxLength(50)
                    .HasColumnName("PF_Liquidity_Profile");

                entity.Property(e => e.PfMaturity)
                    .HasMaxLength(50)
                    .HasColumnName("PF_Maturity");

                entity.Property(e => e.PfNaicsCode)
                    .HasMaxLength(50)
                    .HasColumnName("PF_NAICS_Code");

                entity.Property(e => e.PfRegion)
                    .HasMaxLength(50)
                    .HasColumnName("PF_Region");

                entity.Property(e => e.PfSector)
                    .HasMaxLength(50)
                    .HasColumnName("PF_Sector");

                entity.Property(e => e.PfSubAssetClass)
                    .HasMaxLength(50)
                    .HasColumnName("PF_Sub_Asset_Class");

                entity.Property(e => e.PricingCurrency)
                    .HasMaxLength(50)
                    .HasColumnName("Pricing_Currency");

                entity.Property(e => e.ReturnYtd)
                    .HasMaxLength(50)
                    .HasColumnName("Return_YTD");

                entity.Property(e => e.RiskCurrency)
                    .HasMaxLength(50)
                    .HasColumnName("Risk_Currency");

                entity.Property(e => e.SecurityDescription)
                    .HasMaxLength(50)
                    .HasColumnName("Security_Description");

                entity.Property(e => e.SecurityName)
                    .HasMaxLength(50)
                    .HasColumnName("Security_Name");

                entity.Property(e => e.Sedol)
                    .HasMaxLength(50)
                    .HasColumnName("SEDOL");

                entity.Property(e => e.SettleDays).HasColumnName("Settle_Days");

                entity.Property(e => e.SharesPerAdr)
                    .HasMaxLength(50)
                    .HasColumnName("Shares_Per_ADR");

                entity.Property(e => e.ShortInterest)
                    .HasMaxLength(50)
                    .HasColumnName("Short_Interest");

                entity.Property(e => e.TickerAndExchange)
                    .HasMaxLength(50)
                    .HasColumnName("Ticker_and_Exchange");

                entity.Property(e => e.TotalSharesOutstanding).HasColumnName("Total_Shares_Outstanding");

                entity.Property(e => e.TradingCurrency)
                    .HasMaxLength(50)
                    .HasColumnName("Trading_Currency");

                entity.Property(e => e.Volatility90d).HasColumnName("Volatility_90D");

                entity.Property(e => e.Volume).HasMaxLength(50);

                entity.Property(e => e.VotingRightsPerShare)
                    .HasMaxLength(50)
                    .HasColumnName("Voting_Rights_Per_Share");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
