import * as React from 'react';
import AppBar from '@mui/material/AppBar';
import Box from '@mui/material/Box';
import Toolbar from '@mui/material/Toolbar';
import Typography from '@mui/material/Typography';
import Radio from '@mui/material/Radio';
import RadioGroup from '@mui/material/RadioGroup';
import FormControlLabel from '@mui/material/FormControlLabel';
import FormControl from '@mui/material/FormControl';
import FormLabel from '@mui/material/FormLabel';

interface Props{
    setRadio?:any;
    radio?:any;
}



const Header = ({setRadio, radio}:Props) => {

    const handleChange = (event: React.ChangeEvent<HTMLInputElement>) => {
        setRadio((event.target as HTMLInputElement).value);
    };

    return(
    <Box>
    <AppBar position="static">
    <Toolbar  sx={{backgroundColor:"#00838f", padding:"3px", width:"100vw"}}>
      <Typography variant="h5" component="div">
        Security Master
      </Typography>
    </Toolbar>
  </AppBar>
  <FormControl sx={{marginTop:"30px"}}>
  <FormLabel id="demo-radio-buttons-group-label">Asset class</FormLabel>
  <RadioGroup row
    aria-labelledby="demo-radio-buttons-group-label"
    defaultValue="equity"
    onChange={handleChange}
    name="radio-buttons-group"
  >
    <FormControlLabel value="equity"  control={<Radio size="medium" />} label="Equity" />
    <FormControlLabel value="bond" control={<Radio size="medium" />} label="Bond" />
  </RadioGroup>
</FormControl>
  </Box>
    )
}

export default Header
