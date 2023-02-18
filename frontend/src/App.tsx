import React, { useState } from 'react';
import './App.css';
import Header from './Header';
import ToggleButtonGroupBond from './ToggleButtonGroupBond';
import ToggleButtonGroupEquity from './ToggleButtonGroupEquity';


const EquityOrBond = (radio: string) => {
  if(radio=="equity"){
    return <ToggleButtonGroupEquity/>
  }else{
    return <ToggleButtonGroupBond/>
  }
}




function App() {
  const [radio, setRadioChoice] = useState("equity");

  // EquityOrBond(radio);

  return (
    <div className="App">
     <Header radio={radio} setRadio={setRadioChoice}/>
     {EquityOrBond(radio)}
    </div>
  );
}

export default App;
