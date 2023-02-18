import * as React from 'react';
import ToggleButton from '@mui/material/ToggleButton';
import ToggleButtonGroup from '@mui/material/ToggleButtonGroup';
import { Box } from '@mui/system';
import { useEffect, useState } from 'react';
import './Table.css';


export default function ColorToggleButton() {
  const [bondTab, setbondTab] = useState("Security Summary");
  const [bondData, setbondData] = useState<any[]>([]);

  const handleChange = (
    event: React.MouseEvent<HTMLElement>,
    newbondTab: string | null,
  ) => {
    if (newbondTab !== null) {
      setbondTab(newbondTab);
    }
  };



  useEffect( () => { 
    fetch("http://localhost:5118/Bond/GetBond").
    then(data=>data.json()).
    then(data=>{
      setbondData(data);
    });
  }, [])

  function returnData(){
    if(bondTab=="Security Summary"){
      return(
        <div>
          <table>
            <tr>
            <th>Security Description</th>
            <th>Security Name</th>
            <th>Asset Type</th>
            <th>Investment Type</th>
            <th>Trading Factor</th>
            <th>Pricing Factor</th>
            </tr>


      {Array.isArray(bondData) && bondData.map(object => (
        <tr key={object.bid}>
          <td>{object.securityDescription}</td>
          <td>{object.securityName}</td>
          <td>{object.assetType}</td>
          <td>{object.investmentType}</td>
          <td>{object.tradingFactor}</td>
          <td>{object.pricingFactor}</td>
          </tr>
      ))}
      </table>
    </div>
      )
    }else if(bondTab=="Security Identifier"){
      return(
        <div>
          <table>
            <tr>
            <th>ISIN</th>
            <th>Bloomberg Ticker</th>
            <th>Bloomberg Unique Id</th>
            <th>CUSIP</th>
            <th>SEDOL</th>
            </tr>

      {Array.isArray(bondData) && bondData.map(object => (
        <tr key={object.bid}>
          <td>{object.isin}</td>
        <td>{object.bbgTicker}</td>
        <td> {object.bbgUniqueId} </td>
        <td> {object.cusip} </td>
        <td> {object.sedol} </td>

        </tr>
      ))}
      


      </table>
    </div>
      )
    }else if(bondTab=="Security Details"){
      return(
        <div>
          <table>
            <tr>
            <th>First Coupon Date</th>
            <th>Coupon Cap</th>
            <th>Coupon Floor</th>
            <th>Coupon Frequency</th>
            <th>Coupon Rate</th>
            <th>Coupon Type</th>
            <th>Float Spread</th>
            <th>Is Callable</th>
            <th>Is Fix to Float</th>
            <th>Is Putable</th>
            <th>Issue Date</th>
            <th>Last Reset Date</th>
            <th>Maturity Date</th>
            <th>Maximum Call Notice Days</th>
            <th>Maximum Call Put Notice Days</th>
            <th>Penultimate Coupon Date</th>
            <th>Reset Frequency</th>
            <th>Has Position</th>
            </tr>
      {Array.isArray(bondData) && bondData.map(object => (
        <tr key={object.bid}>

          <td>{object.firstCouponDate}</td>
        <td>{object.cap}</td>
        <td> {object.floor} </td>
        <td> {object.couponFrequency} </td>
        <td> {object.coupon} </td>
        <td> {object.couponType} </td>
        <td> {object.spread}</td>
        <td> {object.callableFlag}</td>
        <td> {object.fixToFloatFlag}</td>
        <td> {object.putableFlag}</td>
        <td> {object.issueDate}</td>
        <td> {object.lastResetDate}</td>
        <td> {object.maturity}</td>
        <td> {object.callNotificationMaxDays}</td>
        <td> {object.putNotificationMaxDays}</td>
        <td> {object.penultimateCouponDate}</td>
        <td> {object.resetFrequency}</td>
        <td> {object.hasPosition}</td>


        </tr>
      ))}
      
      </table>
    </div>
      )
    }else if(bondTab=="Risk"){
      return(
        <div>
          <table>
            <tr>
            <th>Duration</th>
            <th>Volatility 30D</th>
            <th>Volatility 90D</th>
            <th>Convexity</th>
            <th>Average Volume 30D</th>
            </tr>

           
      {Array.isArray(bondData) && bondData.map(object => (
        <tr key={object.bid}>
          <td>{object.macaulayDuration}</td>
        <td>{object._30dVolatility}</td>
        <td> {object._90dVolatility} </td>
        <td> {object.convexity} </td>
        <td> {object._30dayAverageVolume} </td>
        </tr>
      ))}
      
      </table>
    </div>
      )
    }else if(bondTab=="Regulatory Details"){
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

      {Array.isArray(bondData) && bondData.map(object => (
        <tr key={object.bid}>
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
    }else if(bondTab=="Reference Data"){
      return(
        <div>
          <table>
            <tr>
            <th>Bloomberg Industry Group</th>
            <th>Bloomberg Industry Sub Group</th>
            <th>Bloomberg Industry Sector</th>
            <th>Issue Country</th>            
            <th>Issue Currency</th>
            <th>Issuer</th>
            <th>Risk Currency</th>
            </tr>

      {Array.isArray(bondData) && bondData.map(object => (
        <tr key={object.bid}>
          <td>{object.bloombergIndustryGroup}</td>
        <td>{object.bloombergIndustrySubGroup}</td>
        <td> {object.bloombergIndustrySubGroup} </td>
        <td> {object.countryOfIssuance} </td>
        <td> {object.issueCurrency} </td>
        <td> {object.issuer} </td>
        <td> {object.riskCurrency} </td>
        <td> {object.tradingCurrency} </td>
        </tr>
      ))}
      
      </table>
    </div>
      )
    }else if(bondTab=="Put Schedule"){
      return(
        <div>
          <table>
            <tr>
            <th>Put Date</th>
            <th>Put Price</th>
            </tr>

            
      {Array.isArray(bondData) && bondData.map(object => (
        <tr key={object.bid}>
          <td>{object.putDate}</td>
        <td>{object.putPrice}</td>
        </tr>
      ))}
      
      </table>
    </div>
      )
    }else if(bondTab=="Pricing And Analytics"){
      return(
        <div>
          <table>
            <tr>
            <th>Ask Price</th>
            <th>High Price</th>
            <th>Low Price</th>
            <th>Open Price</th>
            <th>Volume</th>
            <th>Bid Price</th>
            <th>Last Price</th>
            </tr>

            
      {Array.isArray(bondData) && bondData.map(object => (
        <tr key={object.bid}>
          <td>{object.askPrice}</td>
        <td>{object.highPrice}</td>
        <td> {object.lowPrice} </td>
        <td> {object.openPrice} </td>
        <td> {object.volume} </td>
        <td> {object.bidPrice} </td>
        <td> {object.lastPrice} </td>
        </tr>
      ))}
      
      </table>
    </div>
      )
    }else if(bondTab=="Call Schedule"){
        return(
          <div>
            <table>
              <tr>
              <th>Call Date</th>
              <th>Call Price</th>
              </tr>
  
              
        {Array.isArray(bondData) && bondData.map(object => (
          <tr key={object.bid}>
            <td>{object.callDate}</td>
          <td>{object.callPrice}</td>
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
      value={bondTab}
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
      <ToggleButton value="Put Schedule">Put Schedule</ToggleButton>
      <ToggleButton value="Pricing And Analytics">Pricing And Analytics</ToggleButton>
      <ToggleButton value="Call Schedule">Call Schedule</ToggleButton>
    </ToggleButtonGroup>
    {returnData()}
    </Box>
  );
}
