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
                optionsBuilder.UseSqlServer("Server = 192.168.0.13\\\\\\\\sqlexpress,58264; Database = SecurityMaster_Group9; User = sa; Password=sa@12345678");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AuditBond>(entity =>
            {
                entity.HasKey(e => e.XnId)
                    .HasName("PK__AuditBon__8375CEB9B5A1E73A");

                entity.ToTable("AuditBond");

                entity.Property(e => e.XnId).HasColumnName("XnID");

                entity.Property(e => e.NewAssetType)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.NewBloombergIndustryGroup)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NewBloombergIndustrySector)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NewBloombergIndustrySubGroup)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NewBloombergTicker)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.NewBloombergUniqueId)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.NewCallDate).HasColumnType("datetime");

                entity.Property(e => e.NewCouponType)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.NewCusip)
                    .HasMaxLength(9)
                    .IsUnicode(false)
                    .HasColumnName("NewCUSIP");

                entity.Property(e => e.NewFirstCouponDate).HasColumnType("datetime");

                entity.Property(e => e.NewInvestmentType)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.NewIsin)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("NewISIN");

                entity.Property(e => e.NewIssueCountry)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NewIssueCurrency)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.NewIssueDate).HasColumnType("datetime");

                entity.Property(e => e.NewIssuer)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NewLastResetDate).HasColumnType("datetime");

                entity.Property(e => e.NewMaturityDate).HasColumnType("datetime");

                entity.Property(e => e.NewPenultimateCouponDate).HasColumnType("datetime");

                entity.Property(e => e.NewPfassetClass)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("NewPFAssetClass");

                entity.Property(e => e.NewPfcountry)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("NewPFCountry");

                entity.Property(e => e.NewPfcreditRating)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("NewPFCreditRating");

                entity.Property(e => e.NewPfcurrency)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("NewPFCurrency");

                entity.Property(e => e.NewPfinstrument)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("NewPFInstrument");

                entity.Property(e => e.NewPfliquidityProfile)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("NewPFLiquidityProfile");

                entity.Property(e => e.NewPfmaturity)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("NewPFMaturity");

                entity.Property(e => e.NewPfnaicscode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("NewPFNAICSCode");

                entity.Property(e => e.NewPfregion)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("NewPFRegion");

                entity.Property(e => e.NewPfsector)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("NewPFSector");

                entity.Property(e => e.NewPfsubAssetClass)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("NewPFSubAssetClass");

                entity.Property(e => e.NewPutDate).HasColumnType("datetime");

                entity.Property(e => e.NewRiskCurrency)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.NewSecurityDescription)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.NewSecurityName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NewSedol)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .HasColumnName("NewSEDOL");

                entity.Property(e => e.OldAssetType)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.OldBloombergIndustryGroup)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OldBloombergIndustrySector)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OldBloombergIndustrySubGroup)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OldBloombergTicker)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.OldBloombergUniqueId)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.OldCallDate).HasColumnType("datetime");

                entity.Property(e => e.OldCouponType)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.OldCusip)
                    .HasMaxLength(9)
                    .IsUnicode(false)
                    .HasColumnName("OldCUSIP");

                entity.Property(e => e.OldFirstCouponDate).HasColumnType("datetime");

                entity.Property(e => e.OldInvestmentType)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.OldIsin)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("OldISIN");

                entity.Property(e => e.OldIssueCountry)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OldIssueCurrency)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.OldIssueDate).HasColumnType("datetime");

                entity.Property(e => e.OldIssuer)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OldLastResetDate).HasColumnType("datetime");

                entity.Property(e => e.OldMaturityDate).HasColumnType("datetime");

                entity.Property(e => e.OldPenultimateCouponDate).HasColumnType("datetime");

                entity.Property(e => e.OldPfassetClass)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("OldPFAssetClass");

                entity.Property(e => e.OldPfcountry)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("OldPFCountry");

                entity.Property(e => e.OldPfcreditRating)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("OldPFCreditRating");

                entity.Property(e => e.OldPfcurrency)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("OldPFCurrency");

                entity.Property(e => e.OldPfinstrument)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("OldPFInstrument");

                entity.Property(e => e.OldPfliquidityProfile)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("OldPFLiquidityProfile");

                entity.Property(e => e.OldPfmaturity)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("OldPFMaturity");

                entity.Property(e => e.OldPfnaicscode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("OldPFNAICSCode");

                entity.Property(e => e.OldPfregion)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("OldPFRegion");

                entity.Property(e => e.OldPfsector)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("OldPFSector");

                entity.Property(e => e.OldPfsubAssetClass)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("OldPFSubAssetClass");

                entity.Property(e => e.OldPutDate).HasColumnType("datetime");

                entity.Property(e => e.OldRiskCurrency)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.OldSecurityDescription)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.OldSecurityName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OldSedol)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .HasColumnName("OldSEDOL");

                entity.Property(e => e.SecurityId)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Username)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.XnAction)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.XnDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<AuditEquity>(entity =>
            {
                entity.HasKey(e => e.XnId)
                    .HasName("PK__AuditEqu__8375CEB988B49A88");

                entity.ToTable("AuditEquity");

                entity.Property(e => e.XnId).HasColumnName("XnID");

                entity.Property(e => e.NewAdrunderlyingCurrency)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("NewADRUnderlyingCurrency");

                entity.Property(e => e.NewAdrunderlyingTicker)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("NewADRUnderlyingTicker");

                entity.Property(e => e.NewBloombergGlobalId)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.NewBloombergIndustryGroup)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NewBloombergIndustrySector)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NewBloombergIndustrySubGroup)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NewBloombergTicker)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.NewBloombergTickerAndExchange)
                    .HasMaxLength(35)
                    .IsUnicode(false);

                entity.Property(e => e.NewBloombergUniqueId)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.NewBloombergUniqueName)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.NewCountryOfIncorporation)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.NewCusip)
                    .HasMaxLength(9)
                    .IsUnicode(false)
                    .HasColumnName("NewCUSIP");

                entity.Property(e => e.NewDividendDeclaredDate).HasColumnType("datetime");

                entity.Property(e => e.NewDividendExDate).HasColumnType("datetime");

                entity.Property(e => e.NewDividendPayDate).HasColumnType("datetime");

                entity.Property(e => e.NewDividendRecordDate).HasColumnType("datetime");

                entity.Property(e => e.NewDividendType)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.NewExchange)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NewFrequency)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.NewIpodate)
                    .HasColumnType("datetime")
                    .HasColumnName("NewIPODate");

                entity.Property(e => e.NewIsAdr).HasColumnName("NewIsADR");

                entity.Property(e => e.NewIsin)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("NewISIN");

                entity.Property(e => e.NewIssueCountry)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.NewIssueCurrency)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.NewIssuer)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NewPeratio).HasColumnName("NewPERatio");

                entity.Property(e => e.NewPfassetClass)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("NewPFAssetClass");

                entity.Property(e => e.NewPfcountry)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("NewPFCountry");

                entity.Property(e => e.NewPfcreditRating)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("NewPFCreditRating");

                entity.Property(e => e.NewPfcurrency)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("NewPFCurrency");

                entity.Property(e => e.NewPfinstrument)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("NewPFInstrument");

                entity.Property(e => e.NewPfliquidityProfile)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("NewPFLiquidityProfile");

                entity.Property(e => e.NewPfmaturity)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("NewPFMaturity");

                entity.Property(e => e.NewPfnaicscode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("NewPFNAICSCode");

                entity.Property(e => e.NewPfregion)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("NewPFRegion");

                entity.Property(e => e.NewPfsector)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("NewPFSector");

                entity.Property(e => e.NewPfsubAssetClass)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("NewPFSubAssetClass");

                entity.Property(e => e.NewPriceCurrency)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.NewRiskCurrency)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.NewSecurityDescription)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.NewSecurityName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NewSedol)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .HasColumnName("NewSEDOL");

                entity.Property(e => e.NewSharesPerAdr).HasColumnName("NewSharesPerADR");

                entity.Property(e => e.NewTradingCurrency)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.NewYtdreturn).HasColumnName("NewYTDReturn");

                entity.Property(e => e.OldAdrunderlyingCurrency)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("OldADRUnderlyingCurrency");

                entity.Property(e => e.OldAdrunderlyingTicker)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("OldADRUnderlyingTicker");

                entity.Property(e => e.OldBloombergGlobalId)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.OldBloombergIndustryGroup)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OldBloombergIndustrySector)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OldBloombergIndustrySubGroup)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OldBloombergTicker)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.OldBloombergTickerAndExchange)
                    .HasMaxLength(35)
                    .IsUnicode(false);

                entity.Property(e => e.OldBloombergUniqueId)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.OldBloombergUniqueName)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.OldCountryOfIncorporation)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.OldCusip)
                    .HasMaxLength(9)
                    .IsUnicode(false)
                    .HasColumnName("OldCUSIP");

                entity.Property(e => e.OldDividendDeclaredDate).HasColumnType("datetime");

                entity.Property(e => e.OldDividendExDate).HasColumnType("datetime");

                entity.Property(e => e.OldDividendPayDate).HasColumnType("datetime");

                entity.Property(e => e.OldDividendRecordDate).HasColumnType("datetime");

                entity.Property(e => e.OldDividendType)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.OldExchange)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OldFrequency)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.OldIpodate)
                    .HasColumnType("datetime")
                    .HasColumnName("OldIPODate");

                entity.Property(e => e.OldIsAdr).HasColumnName("OldIsADR");

                entity.Property(e => e.OldIsin)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("OldISIN");

                entity.Property(e => e.OldIssueCountry)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.OldIssueCurrency)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.OldIssuer)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OldPeratio).HasColumnName("OldPERatio");

                entity.Property(e => e.OldPfassetClass)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("OldPFAssetClass");

                entity.Property(e => e.OldPfcountry)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("OldPFCountry");

                entity.Property(e => e.OldPfcreditRating)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("OldPFCreditRating");

                entity.Property(e => e.OldPfcurrency)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("OldPFCurrency");

                entity.Property(e => e.OldPfinstrument)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("OldPFInstrument");

                entity.Property(e => e.OldPfliquidityProfile)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("OldPFLiquidityProfile");

                entity.Property(e => e.OldPfmaturity)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("OldPFMaturity");

                entity.Property(e => e.OldPfnaicscode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("OldPFNAICSCode");

                entity.Property(e => e.OldPfregion)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("OldPFRegion");

                entity.Property(e => e.OldPfsector)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("OldPFSector");

                entity.Property(e => e.OldPfsubAssetClass)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("OldPFSubAssetClass");

                entity.Property(e => e.OldPriceCurrency)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.OldRiskCurrency)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.OldSecurityDescription)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.OldSecurityName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OldSedol)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .HasColumnName("OldSEDOL");

                entity.Property(e => e.OldSharesPerAdr).HasColumnName("OldSharesPerADR");

                entity.Property(e => e.OldTradingCurrency)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.OldYtdreturn).HasColumnName("OldYTDReturn");

                entity.Property(e => e.SecurityId)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Username)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.XnAction)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.XnDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<Bond>(entity =>
            {
                entity.HasKey(e => e.SecurityId)
                    .HasName("PK__Bond__9F8B0930B6788433");

                entity.ToTable("Bond");

                entity.HasIndex(e => e.SecurityName, "UQ__Bond__D10C458C26114822")
                    .IsUnique();

                entity.Property(e => e.SecurityId)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AssetType)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.BloombergIndustryGroup)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BloombergIndustrySector)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BloombergIndustrySubGroup)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BloombergTicker)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.BloombergUniqueId)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.CallDate).HasColumnType("datetime");

                entity.Property(e => e.CouponType)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Cusip)
                    .HasMaxLength(9)
                    .IsUnicode(false)
                    .HasColumnName("CUSIP");

                entity.Property(e => e.FirstCouponDate).HasColumnType("datetime");

                entity.Property(e => e.InvestmentType)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Isin)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("ISIN");

                entity.Property(e => e.IssueCountry)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IssueCurrency)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.IssueDate).HasColumnType("datetime");

                entity.Property(e => e.Issuer)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastResetDate).HasColumnType("datetime");

                entity.Property(e => e.MaturityDate).HasColumnType("datetime");

                entity.Property(e => e.PenultimateCouponDate).HasColumnType("datetime");

                entity.Property(e => e.PfassetClass)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("PFAssetClass");

                entity.Property(e => e.Pfcountry)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("PFCountry");

                entity.Property(e => e.PfcreditRating)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("PFCreditRating");

                entity.Property(e => e.Pfcurrency)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PFCurrency");

                entity.Property(e => e.Pfinstrument)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("PFInstrument");

                entity.Property(e => e.PfliquidityProfile)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("PFLiquidityProfile");

                entity.Property(e => e.Pfmaturity)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("PFMaturity");

                entity.Property(e => e.Pfnaicscode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PFNAICSCode");

                entity.Property(e => e.Pfregion)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("PFRegion");

                entity.Property(e => e.Pfsector)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PFSector");

                entity.Property(e => e.PfsubAssetClass)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("PFSubAssetClass");

                entity.Property(e => e.PutDate).HasColumnType("datetime");

                entity.Property(e => e.RiskCurrency)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.SecurityDescription)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SecurityName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Sedol)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .HasColumnName("SEDOL");
            });

            modelBuilder.Entity<Equity>(entity =>
            {
                entity.HasKey(e => e.SecurityId)
                    .HasName("PK__Equity__9F8B09308B57C931");

                entity.ToTable("Equity");

                entity.HasIndex(e => e.SecurityName, "UQ__Equity__D10C458C5CF188D8")
                    .IsUnique();

                entity.Property(e => e.SecurityId)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AdrunderlyingCurrency)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("ADRUnderlyingCurrency");

                entity.Property(e => e.AdrunderlyingTicker)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("ADRUnderlyingTicker");

                entity.Property(e => e.BloombergGlobalId)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.BloombergIndustryGroup)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BloombergIndustrySector)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BloombergIndustrySubGroup)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BloombergTicker)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.BloombergTickerAndExchange)
                    .HasMaxLength(35)
                    .IsUnicode(false);

                entity.Property(e => e.BloombergUniqueId)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.BloombergUniqueName)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.CountryOfIncorporation)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Cusip)
                    .HasMaxLength(9)
                    .IsUnicode(false)
                    .HasColumnName("CUSIP");

                entity.Property(e => e.DividendDeclaredDate).HasColumnType("datetime");

                entity.Property(e => e.DividendExDate).HasColumnType("datetime");

                entity.Property(e => e.DividendPayDate).HasColumnType("datetime");

                entity.Property(e => e.DividendRecordDate).HasColumnType("datetime");

                entity.Property(e => e.DividendType)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Exchange)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Frequency)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Ipodate)
                    .HasColumnType("datetime")
                    .HasColumnName("IPODate");

                entity.Property(e => e.IsAdr).HasColumnName("IsADR");

                entity.Property(e => e.Isin)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("ISIN");

                entity.Property(e => e.IssueCountry)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.IssueCurrency)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Issuer)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Peratio).HasColumnName("PERatio");

                entity.Property(e => e.PfassetClass)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("PFAssetClass");

                entity.Property(e => e.Pfcountry)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("PFCountry");

                entity.Property(e => e.PfcreditRating)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("PFCreditRating");

                entity.Property(e => e.Pfcurrency)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PFCurrency");

                entity.Property(e => e.Pfinstrument)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("PFInstrument");

                entity.Property(e => e.PfliquidityProfile)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("PFLiquidityProfile");

                entity.Property(e => e.Pfmaturity)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("PFMaturity");

                entity.Property(e => e.Pfnaicscode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PFNAICSCode");

                entity.Property(e => e.Pfregion)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("PFRegion");

                entity.Property(e => e.Pfsector)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PFSector");

                entity.Property(e => e.PfsubAssetClass)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("PFSubAssetClass");

                entity.Property(e => e.PriceCurrency)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.RiskCurrency)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.SecurityDescription)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SecurityName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Sedol)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .HasColumnName("SEDOL");

                entity.Property(e => e.SharesPerAdr).HasColumnName("SharesPerADR");

                entity.Property(e => e.TradingCurrency)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Ytdreturn).HasColumnName("YTDReturn");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
