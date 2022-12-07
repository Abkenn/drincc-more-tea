import { AxiosPromise } from 'axios';
import { ApiResponse } from '../interfaces/ApiResopnse.interface';
import { Dictionary } from '../types/Dictionary.type';

export const isNonEmptyArray = (value: Array<unknown>) => Array.isArray(value) && (value as unknown[]).length > 0;

export const isNonEmptyString = (value: unknown) => typeof value === 'string' && value !== '';

export const debounce = (id: number | string, delay?: number): (callback: () => void) => void => {
  const timers: Dictionary<NodeJS.Timeout> = {};

  return (callback) => {
    if (timers[id]) {
      clearTimeout(timers[id]);
    }

    timers[id] = setTimeout(callback, delay ?? 300);
  };
};

export const fetchPayload = (promise: AxiosPromise<unknown>) => promise.then((res) => (res as ApiResponse).data.payload);
