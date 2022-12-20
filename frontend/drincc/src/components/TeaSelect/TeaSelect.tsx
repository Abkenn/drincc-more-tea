import { useEffect, useState } from 'react';
import Select from 'react-select';
import useDidMount from '../../hooks/useDidMount';
import { getTea, getTeas } from '../../api/teaMock';
import { ApiError } from '../../types/ApiResponse.type';
import { Tea } from '../../types/Tea.type';
import './index.scss';

type SelectOptions = { value: number, label: string }[];

const TeaSelect: React.FunctionComponent = () => {
  const [teas, setTeas] = useState<Tea[] | null>(null);
  const [selectedTea, setSelectedTea] = useState<Tea | null>(null);
  const [selectedTeaId, setSelectedTeaId] = useState<number | undefined>(undefined);

  const getOptions = (): SelectOptions | undefined => teas?.map((tea) => ({ value: tea.id, label: tea.name }));

  useEffect(() => {
    getTeas()
      .then((data) => setTeas(data.payload))
      .catch((error: ApiError) => console.warn(error.message));
  }, []);

  useDidMount(() => {
    // GET /teas/{selectedTeaId}
    getTea(Number(selectedTeaId))
      .then((data) => setSelectedTea(data.payload))
      .catch((error: ApiError) => console.warn(error.message));
  }, [selectedTeaId]);

  useDidMount(() => {
    console.log(selectedTea);
  }, [selectedTea]);

  return (
    <div className="tea-select">
      <Select
        className="tea-select__select"
        isDisabled={teas?.length === 0}
        filterOption={({ label }, inputValue) => label.toLowerCase().includes(inputValue.toLowerCase())}
        options={getOptions()}
        onChange={(selected) => setSelectedTeaId(selected?.value)}
      />
    </div>
  );
};

export default TeaSelect;
