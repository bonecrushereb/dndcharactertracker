import React, { Fragment, useEffect, useState } from 'react';
import axios from 'axios';
import { Container, List } from 'semantic-ui-react';
import { Character } from '../models/character';
import Navbar from './Navbar';
import CharacterDashboard from '../../features/characters/dashboard/CharacterDashboard';

function App() {
  const [characters, setCharacters] = useState<Character[]>([]);

  useEffect(() => {
    axios.get('http://localhost:5000/api/Character')
      .then(response => {
        setCharacters(response.data);
      })
  }, [])

  return (
    <Fragment>
      <Navbar />
      <Container style={{marginTop: '7em'}}>
        <CharacterDashboard characters={characters}/>
      </Container>
    
    </Fragment>
  );
}

export default App;
