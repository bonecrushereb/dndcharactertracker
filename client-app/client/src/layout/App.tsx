import React, { Fragment } from 'react';
import './App.css';
import Navbar from './Navbar';
import CharacterDashboard from '../features/characters/dashboard/CharacterDashboard';
import { Container } from 'semantic-ui-react';

function App() {
  return (
    <Fragment>
      <Navbar />
      <Container>
        <CharacterDashboard />
      </Container>
    </Fragment>
  );
}

export default App;
