import React, { useEffect } from 'react';
import Navbar from './Navbar';
import CharacterDashboard from '../../features/characters/dashboard/CharacterDashboard';
import { Route, BrowserRouter as Router, Routes } from 'react-router-dom';
import CharacterDetails from '../../features/characters/details/CharacterDetails';
import { useStore } from '../store/store';
import { observer } from 'mobx-react-lite';

function App() {
  const{characterStore} = useStore();

  useEffect(() => {
    characterStore.loadCharacters();
  }, [characterStore]);

  return (
    <Router>
      <Navbar />
      <Routes>
        <Route path='/' element={<CharacterDashboard />} />
        <Route path='/characters/:id' element={<CharacterDetails />}
      </Routes>
    </Router>
  );
}

export default observer(App);
