import { useEffect, useState } from 'react';
import { getForecast } from '../../api/weather';

const Home: React.FunctionComponent = () => {
  const [forecast, setForecast] = useState<unknown>();

  useEffect(() => {
    getForecast()
      .then((response: unknown) => setForecast(response));
  }, []);
  return (
    <div>
      {JSON.stringify(forecast)}
    </div>
  );
};

export default Home;