import { AxiosPromise } from 'axios';
import axiosInstance from '../axios';

export const getForecast = (): AxiosPromise => (
  axiosInstance.get('/WeatherForecast')
);