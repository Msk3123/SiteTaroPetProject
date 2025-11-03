import React from 'react';
import MainPage from './components/MainPage';
import './App.css';

function App() {
  return (
    <div className="App">
      <header className="App-header">
        <h1>🔮 Таро Карти</h1>
        <p>Система управління колодою Таро</p>
      </header>
      <main>
        <MainPage />
      </main>
    </div>
  );
}

export default App;
