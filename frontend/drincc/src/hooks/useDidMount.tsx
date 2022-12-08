import { DependencyList, useEffect, useRef } from 'react';

const useDidMount = (action: () => unknown, inputs: DependencyList): void => {
  const didMountRef = useRef<boolean>(false);

  return useEffect(() => {
    if (didMountRef.current) {
      action();
    } else {
      didMountRef.current = true;
    }
    // eslint-disable-next-line react-hooks/exhaustive-deps
  }, inputs);
};

export default useDidMount;
