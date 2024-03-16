import React, { useState } from 'react';
import BowlerList from './Bowler/BowlerList';

const PageHeader = () => {
  return (
    <>
      <h1>Welcome to our Bowling League page.</h1>
      <p>
        Here, you can find information about bowlers and teams in our league.
      </p>
    </>
  );
};

function App() {
  return (
    <div className="App">
      <PageHeader />
      <BowlerList />
    </div>
  );
}

export default App;
