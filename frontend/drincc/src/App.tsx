import { BrowserRouter, Route, Routes } from 'react-router-dom';
import Home from './views/Home';
import './App.css';

const App = () => (
  <BrowserRouter>
  <Routes>
    <Route path="/" element={<Home />} />
  </Routes>
</BrowserRouter>
);

export default App;
