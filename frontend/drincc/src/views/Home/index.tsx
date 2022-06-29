import { useEffect, useRef, useState } from 'react';
import { uid } from 'uid';
import { getTeas, deleteTea, getTea, updateTea, addTea } from '../../api/tea';
import { ApiResponse } from '../../interfaces/ApiResopnse.interface';
import { Tea } from '../../types/Tea.type';
import { debounce, isNonEmptyArray, isNonEmptyString } from '../../utils';

const Home: React.FunctionComponent = () => {
  const [teaList, setTeaList] = useState<Tea[]>([]);
  const [foundTea, setFoundTea] = useState<Tea | null>(null);
  const [teaIdForSearch, setTeaIdForSearch] = useState<string>();
  const [teaNameToUpdate, setTeaNameToUpdate] = useState<string>();
  const [teaNameToAdd, setTeaNameToAdd] = useState<string>();
  const debouncer = useRef(debounce(uid(), 200));

  const onDelete = (id: number) => deleteTea(id)
    .then(() => setTeaList(teaList.filter(tea => tea.id !== id)));

  const onEdit = () => updateTea(Number(foundTea?.id), { name: teaNameToUpdate } as Partial<Tea>)
    .then((response: unknown) => {
      const { payload } = (response as ApiResponse).data;
      const updatedTea = payload as Tea;
      let updatedList = [] as Tea[];
      teaList.forEach((prevTea: Tea) => updatedList.push({ ...prevTea, name: prevTea.id === updatedTea.id ? updatedTea.name : prevTea.name }))
      setTeaList(updatedList);
    })
    .finally(() => setTeaNameToUpdate(''));

  const onAdd = () => addTea({ name: teaNameToAdd } as Partial<Tea>)
    .then((response: unknown) => {
      const { payload } = (response as ApiResponse).data;
      const updatedTea = payload as Tea;
      setTeaList(prevList => [
        ...prevList,
        updatedTea
      ]);
    })
    .finally(() => setTeaNameToAdd(''));

  const onChangeSearchInput = (value: string) => {
    setTeaIdForSearch('');
    debouncer.current(() => {
      setTeaIdForSearch(value);
    });
  }

  useEffect(() => {
    getTeas()
      .then((response: unknown) => {
        const { payload } = (response as ApiResponse).data;
        setTeaList(payload as Tea[])
      });
  }, []);

  useEffect(() => {
    if (isNonEmptyString(teaIdForSearch)) {
      getTea(Number(teaIdForSearch))
        .then((response: unknown) => {
          const { payload } = (response as ApiResponse).data;
          setFoundTea(payload as Tea)
        })
        .catch(() => setFoundTea(null));
    } else {
      setFoundTea(null);
    }
  }, [teaIdForSearch]);

  return (
    <div className="home">
      <div>
        {isNonEmptyArray(teaList) ? teaList
          .map(tea => (
            <button
              key={uid()}
              onClick={() => onDelete(tea.id)}
            >
              {tea.name}
            </button>
          )) : (
          <div>
            The tea list is empty...
          </div>
        )}
      </div>

      <div>
        <input
          placeholder="id"
          onChange={(event: React.ChangeEvent<HTMLInputElement>) => onChangeSearchInput(event.target.value)}
        />
      </div>

      {foundTea === null ? (
        <div>
          <input
            placeholder="add new tea"
            onChange={(event: React.ChangeEvent<HTMLInputElement>) => setTeaNameToAdd(event.target.value)}
          />
          <div>
            <button onClick={() => onAdd()}>Add</button>
          </div>
        </div>
      ) : (
        <>
          <div>
            Found this tea: {foundTea?.name}
          </div>

          <input
            placeholder={`rename ${foundTea?.name}`}
            onChange={(event: React.ChangeEvent<HTMLInputElement>) => setTeaNameToUpdate(event.target.value)}
          />

          <div>
            <button
              disabled={isNaN(Number(foundTea.id))}
              onClick={() => onEdit()}
            >Edit</button>
          </div>
        </>
      )}
    </div>
  );
};

export default Home;