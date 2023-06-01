import React, { useEffect, useState } from 'react';
import logo from './logo.svg';
import './App.css';
import axios from 'axios';

function App() {
  const [characters, setCharacters] = useState<any>([]);

  useEffect(() => {
    axios.get('http://localhost:5000/api/Character')
      .then(response => {
        console.log(response);
        setCharacters(response.data);
      })
  }, [])

  return (
    <div className="App">
      <header className="App-header">
        <img src={logo} className="App-logo" alt="logo" />
        <ul>
          {characters.map((character: any) => {
            return <li key={character.id}>
              {character.name}
            </li>
          })}
        </ul>
      </header>
    </div>
  );
}

export default App;
