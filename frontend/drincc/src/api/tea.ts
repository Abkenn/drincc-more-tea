import { AxiosPromise } from 'axios';
import axiosInstance from '../axios';
import { Tea } from '../types/Tea.type';

export const getTeas = (): AxiosPromise => (
  axiosInstance.get('/tea')
);

export const getTea = (id: number): AxiosPromise => (
  axiosInstance.get(`/tea/${id}`)
);

export const addTea = (tea: Partial<Tea>): AxiosPromise => (
  axiosInstance.post('/tea', tea)
)
export const updateTea = (tea: Tea): AxiosPromise => (
  axiosInstance.put('/tea', tea)
)

export const deleteTea = (id: number): AxiosPromise => (
  axiosInstance.delete(`/tea/${id}`)
);