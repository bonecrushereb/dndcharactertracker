import React from 'react';
import { Provider } from 'react-redux';
import store from './store';
import { Route, BrowserRouter as Router, Routes } from 'react-router-dom';
import Navbar from './components/layout/Navbar';
import CharacterDashboard from './components/dashboard/CharacterDashboard';
import './App.css';
import CharacterDetails from './components/character/characterdetails';
import CharacterForm from './components/character-form/CharacterForm';

const App = () => {
  return (
    <Provider store={store}>
      <Router>
      <Navbar />
        <Routes>
          <Route path='/' element={<CharacterDashboard />} />
          <Route path="/characters/:id" element={<CharacterDetails />} />
          <Route path="/characters/create" element={<CharacterForm /> } />
        </Routes>
      </Router>
    </Provider>
  );
}

export default App;
