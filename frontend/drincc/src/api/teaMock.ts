import axiosInstance from '../axios';
import { ApiResponse } from '../types/ApiResponse.type';
import { Tea } from '../types/Tea.type';

export const getTeas = (): ApiResponse<Tea[]> => (
  axiosInstance.get('/mock-tea')
);

export const getTea = (id: number): ApiResponse<Tea> => (
  axiosInstance.get(`/mock-tea/${id}`)
);

export const addTea = (tea: Partial<Tea>): ApiResponse<Tea> => (
  axiosInstance.post('/mock-tea', tea)
);
export const updateTea = (id: number, tea: Partial<Tea>): ApiResponse<Tea> => (
  axiosInstance.put(`/mock-tea/${id}`, tea)
);

export const deleteTea = (id: number): ApiResponse => (
  axiosInstance.delete<never>(`/mock-tea/${id}`)
);
