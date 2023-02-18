import * as React from 'react';
import ToggleButton from '@mui/material/ToggleButton';
import ToggleButtonGroup from '@mui/material/ToggleButtonGroup';
import { Box } from '@mui/system';
import { useEffect, useState } from 'react';
import SecuritySummary from './EquityTables/SecuritySummary';
import './Table.css';


export default function ColorToggleButton() {
  const [equityTab, setEquityTab] = useState("Security Summary");
  const [equityData, setEquityData] = useState<any[]>([]);

  const handleChange = (
    event: React.MouseEvent<HTMLElement>,
    newEquityTab: string | null,
  ) => {
    if (newEquityTab !== null) {
      setEquityTab(newEquityTab);
    }
  };



  useEffect( () => { 
    fetch("http://localhost:5118/Equity/GetEquity").
    then(data=>data.json()).
    then(data=>{
      setEquityData(data);
    });
  }, [])

  function returnData(){
    if(equityTab=="Security Summary"){
      return(
        <div>
          <table>
            <tr>
            <th>Security Name</th>
            <th>Security Description</th>
            <th>Has Position</th>
            <th>Active Security</th>
            <th>Lot Size</th>
            <th>BloomBerg Unique Name</th>
            </tr>
      {Array.isArray(equityData) && equityData.map(object => (
        <tr key={object.sid}>
          <td>{object.securityName}</td>
          <td>{object.securityDescription}</td>
          <td>{object.hasPosition==true?"true":"false"}</td>
          <td>{object.isActiveSecurity==true?"true":"false"}</td>
          <td>{object.lotSize}</td>
          <td>{object.bbgUniqueName}</td></tr>
      ))}
      </table>
    </div>
      )
    }else if(equityTab=="Security Identifier"){
      return(
        <div>
          <table>
            <tr>
            <th>CUSIP</th>
            <th>ISIN</th>
            <th>SEDOL</th>
            <th>Bloomberg Ticker</th>
            <th>Bloomberg Unique Id</th>
            <th>Bloomberg Global Id</th>
            <th>Bloomberg Ticker And Exchange</th>
            </tr>
      {Array.isArray(equityData) && equityData.map(object => (
        <tr key={object.sid}>
          <td>{object.cusip}</td>
        <td>{object.isin}</td>
        <td> {object.sedol} </td>
        <td> {object.bloombergTicker} </td>
        <td> {object.bloombergUniqueId} </td>
        <td> {object.bbgGlobalId} </td>
        <td> {object.tickerAndExchange}</td>
        </tr>
      ))}
      


      </table>
    </div>
      )
    }else if(equityTab=="Security Details"){
      return(
        <div>
          <table>
            <tr>
            <th>IS ADR</th>
            <th>ADR Underlying Ticker</th>
            <th>ADR Underlying Currency</th>
            <th>Shares Per ADR</th>
            <th>IPO Date</th>
            <th>Price Currency</th>
            <th>Settle Days</th>
            <th>Shares Outstanding</th>
            <th>Voting Rights Per Share</th>
            </tr>
      {Array.isArray(equityData) && equityData.map(object => (
        <tr key={object.sid}>
          <td>{object.isAdrFlag==true?"true":"false"}</td>
        <td>{object.adrUnderlyingTicker}</td>
        <td> {object.adrUnderlyingCurrency} </td>
        <td> {object.sharesPerAdr} </td>
        <td> {object.ipoDate} </td>
        <td> {object.pricingCurrency} </td>
        <td> {object.settleDays}</td>
        <td> {object.totalSharesOutstanding}</td>
        <td> {object.votingRightsPerShare}</td>
        </tr>
      ))}
      
      </table>
    </div>
      )
    }else if(equityTab=="Risk"){
      return(
        <div>
          <table>
            <tr>
            <th>20 Day Average Volume</th>
            <th>Beta</th>
            <th>Short Interest</th>
            <th>YTD Return</th>
            <th>90 Day Price Volatility</th>
            </tr>

      {Array.isArray(equityData) && equityData.map(object => (
        <tr key={object.sid}>
          <td>{object.averageVolume20d}</td>
        <td>{object.beta}</td>
        <td> {object.shortInterest} </td>
        <td> {object.returnYtd} </td>
        <td> {object.volatility90d} </td>
        </tr>
      ))}
      
      </table>
    </div>
      )
    }else if(equityTab=="Regulatory Details"){
      return(
        <div>
          <table>
            <tr>
            <th>Form PF Asset Class</th>
            <th>Form PF Country</th>
            <th>Form PF Credit Rating</th>
            <th>Form PF Currency</th>
            <th>Form PF Instrument</th>
            <th>Form PF Liquid Profile</th>
            <th>Form PF Maturity</th>
            <th>Form PF NAICS Code</th>
            <th>Form PF Region</th>
            <th>Form PF Sector</th>
            <th>Form PF Sub Asset Clas</th>
            </tr>

      {Array.isArray(equityData) && equityData.map(object => (
        <tr key={object.sid}>
          <td>{object.pfAssetClass}</td>
        <td>{object.pfCountry}</td>
        <td> {object.pfCreditRating} </td>
        <td> {object.pfCurrency} </td>
        <td> {object.pfInstrument} </td>
        <td> {object.pfLiquidityProfile} </td>
        <td> {object.pfMaturity} </td>
        <td> {object.pfNaicsCode} </td>
        <td> {object.pfRegion} </td>
        <td> {object.pfSector} </td>
        <td> {object.pfSubAssetClass} </td>
        </tr>
      ))}
      
      </table>
    </div>
      )
    }else if(equityTab=="Reference Data"){
      return(
        <div>
          <table>
            <tr>
            <th>Issue Country</th>
            <th>Exchange</th>
            <th>Issuer</th>
            <th>Issue Currency</th>
            <th>Trading Currency</th>
            <th>Bloomberg Industry Sub Group</th>
            <th>Bloomberg Industry Group</th>
            <th>Bloomberg Industry Sector</th>
            <th>Country Of Incorporation</th>
            </tr>

      {Array.isArray(equityData) && equityData.map(object => (
        <tr key={object.sid}>
          <td>{object.countryOfIssuance}</td>
        <td>{object.exchange}</td>
        <td> {object.issuer} </td>
        <td> {object.issueCurrency} </td>
        <td> {object.tradingCurrency} </td>
        <td> {object.bbgIndustrySubGroup} </td>
        <td> {object.bloombergIndustryGroup} </td>
        <td> {object.bloombergSector} </td>
        <td> {object.countryOfIncorporation} </td>
        </tr>
      ))}
      
      </table>
    </div>
      )
    }else if(equityTab=="Pricing Details"){
      return(
        <div>
          <table>
            <tr>
            <th>Open Price</th>
            <th>Close Price</th>
            <th>Volume</th>
            <th>Last Price</th>
            <th>Ask Price</th>
            <th>Bid Price</th>
            <th>PE Ratio</th>
            </tr>


      {Array.isArray(equityData) && equityData.map(object => (
        <tr key={object.sid}>
          <td>{object.openPrice}</td>
        <td>{object.closePrice}</td>
        <td> {object.volume} </td>
        <td> {object.lastPrice} </td>
        <td> {object.askPrice} </td>
        <td> {object.bidPrice} </td>
        <td> {object.peRatio} </td>
        </tr>
      ))}
      
      </table>
    </div>
      )
    }else if(equityTab=="Dividend History"){
      return(
        <div>
          <table>
            <tr>
            <th>Declared Date</th>
            <th>Ex Date</th>
            <th>Record Date</th>
            <th>Pay Date</th>
            <th>Amount</th>
            <th>Frequency</th>
            <th>Divident Type</th>
            </tr>


      {Array.isArray(equityData) && equityData.map(object => (
        <tr key={object.sid}>
          <td>{object.dividendDeclaredDate}</td>
        <td>{object.dividendExDate}</td>
        <td> {object.dividendRecordDate} </td>
        <td> {object.dividendPayDate} </td>
        <td> {object.dividendAmount} </td>
        <td> {object.frequency} </td>
        <td> {object.dividendType} </td>
        </tr>
      ))}
      
      </table>
    </div>
      )
    }
  }

  return (
    <Box>
    <ToggleButtonGroup
      color="primary"
      value={equityTab}
      exclusive
      onChange={handleChange}
      aria-label="Platform"
    >
      <ToggleButton value="Security Summary">Security Summary</ToggleButton>
      <ToggleButton value="Security Identifier">Security Identifier</ToggleButton>
      <ToggleButton value="Security Details">Security Details</ToggleButton>
      <ToggleButton value="Risk">Risk</ToggleButton>
      <ToggleButton value="Regulatory Details">Regulatory Details</ToggleButton>
      <ToggleButton value="Reference Data">Reference Data</ToggleButton>
      <ToggleButton value="Pricing Details">Pricing Details</ToggleButton>
      <ToggleButton value="Dividend History">Dividend History</ToggleButton>
    </ToggleButtonGroup>
    {returnData()}
    </Box>
  );
}
