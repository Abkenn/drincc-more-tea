import { AxiosPromise } from 'axios';
import axiosInstance from '../axios';
import { Tea } from '../types/Tea.type';

export const getTeas = (): AxiosPromise => (
  axiosInstance.get('/mock-tea')
);

export const getTea = (id: number): AxiosPromise => (
  axiosInstance.get(`/mock-tea/${id}`)
);

export const addTea = (tea: Partial<Tea>): AxiosPromise => (
  axiosInstance.post('/mock-tea', tea)
);
export const updateTea = (id: number, tea: Partial<Tea>): AxiosPromise => (
  axiosInstance.put(`/mock-tea/${id}`, tea)
);

export const deleteTea = (id: number): AxiosPromise => (
  axiosInstance.delete(`/mock-tea/${id}`)
);
