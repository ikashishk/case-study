import * as React from 'react';

interface Props{
    data?:any;
}

export default function DataTable({data}:Props) {

    

  return (
    <div style={{ height: 400, width: '100%' }}>
        <h1>Hello World</h1>
      {data.map((item: { sid: string | number | boolean | React.ReactElement<any, string | React.JSXElementConstructor<any>> | React.ReactFragment | React.ReactPortal | null | undefined; })=>{
        <p>{item.sid}</p>
      })}
    </div>
  );
}