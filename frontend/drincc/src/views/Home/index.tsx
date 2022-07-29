import { useNavigate } from 'react-router-dom';
import Teas from '../Teas';
import './index.scss';

const Home: React.FunctionComponent = () => {
  const navigate = useNavigate();

  return (
    <div className="home">
      <Teas />
    </div>
  );
};

export default Home;