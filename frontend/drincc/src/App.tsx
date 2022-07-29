import { BrowserRouter, Route, Routes } from 'react-router-dom';
import Home from './views/Home';
import Teas from './views/Teas';
import './App.scss';

const App = () => (
  <BrowserRouter>
  <Routes>
    <Route path="/" element={<Home />} />
    <Route path="/teas" element={<Teas />} />
  </Routes>
</BrowserRouter>
);

export default App;
