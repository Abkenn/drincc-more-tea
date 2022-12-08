import { useEffect, useState } from 'react';
import Select from 'react-select';
import { getTea, getTeas } from '../../api/teaMock';
import useDidMount from '../../hooks/useDidMount';
import { fetchPayload } from '../../utils';
import './index.scss';

type SelectOptions = { value: number, label: string }[];
type Tea = { id: number, name: string };

const Teas: React.FunctionComponent = () => {
  const [teas, setTeas] = useState<Tea[] | null>(null);
  const [selectedTea, setSelectedTea] = useState<Tea | null>(null);
  const [selectedTeaId, setSelectedTeaId] = useState<number | undefined>(undefined);

  const getOptions = (): SelectOptions | undefined => teas?.map((tea) => ({ value: tea.id, label: tea.name }));

  useEffect(() => {
    fetchPayload<Tea[]>(getTeas()).then((teasPayload) => setTeas(teasPayload));
  }, []);

  useDidMount(() => {
    // GET /teas/{selectedTeaId}
    fetchPayload<Tea>(getTea(Number(selectedTeaId))).then((teaPayload) => setSelectedTea(teaPayload));
  }, [selectedTeaId]);

  useDidMount(() => {
    console.log(selectedTea);
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
