import { useEffect, useRef, useState } from 'react';
import Select from 'react-select';
import { getTea, getTeas } from '../../api/teaMock';
import { fetchPayload } from '../../utils';
import './index.scss';

type SelectOptions = { value: number, label: string }[];
type Tea = { id: number, name: string };

const Teas: React.FunctionComponent = () => {
  const [teas, setTeas] = useState<Tea[] | null>(null);
  const [selectedTea, setSelectedTea] = useState<Tea | null>(null);
  const [selectedTeaId, setSelectedTeaId] = useState<number | undefined>(undefined);
  const didMountRef = useRef(false);

  const getOptions = (): SelectOptions | undefined => teas?.map((tea) => ({ value: tea.id, label: tea.name }));

  const loadTeasOnMount: () => Promise<void> = async () => setTeas(await fetchPayload(getTeas()) as Tea[]);
  const getSelectedTea: (id: number) => Promise<void> = async (id: number) => setSelectedTea(await fetchPayload(getTea(id)) as Tea);

  useEffect(() => {
    loadTeasOnMount();
  }, []);

  useEffect(() => {
    if (didMountRef.current) {
      // GET /teas/{selectedTeaId}
      getSelectedTea(Number(selectedTeaId));
    }
    didMountRef.current = true;
  }, [selectedTeaId]);

  useEffect(() => {
    if (didMountRef.current) {
      console.log(selectedTea);
    }
  }, [selectedTea]);

  return (
    <div className="teas">
      <div>
        <Select
          className="teas__select"
          isDisabled={teas?.length === 0}
          filterOption={({ label }, inputValue) => label.toLowerCase().includes(inputValue.toLowerCase())}
          options={getOptions()}
          onChange={(selected) => setSelectedTeaId(selected?.value)}
        />
      </div>
    </div>
  );
};

export default Teas;
