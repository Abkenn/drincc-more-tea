import { useEffect, useState } from 'react';
import Select from 'react-select'
import './index.scss';

type SelectOptions = { value: number, label: string }[];
type Tea = { id: number, name: string };

const Teas: React.FunctionComponent = () => {
  const [selectedTeaId, setSelectedTeaId] = useState<number | undefined>(undefined);
  const teas: Tea[] = [
    { id: 0, name: 'Tea 1' },
    { id: 1, name: 'Tea 2' },
    { id: 2, name: 'Tea 3' }
  ];

  const getOptions = (): SelectOptions => teas.map(tea => ({ value: tea.id, label: tea.name }));

  useEffect(() => {
    // GET /teas/{selectedTeaId}
    console.log(selectedTeaId);
  }, [selectedTeaId]);

  return (
    <div className="teas">
      <div>
        <Select
          className="teas__select"
          options={getOptions()}
          onChange={(selected) => setSelectedTeaId(selected?.value)}
        />
      </div>
    </div>
  );
};

export default Teas;