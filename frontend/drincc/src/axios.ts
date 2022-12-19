import axios, { AxiosResponse } from 'axios';
import {
  ApiAxiosError, ApiData, ApiErrorResponse, PayloadConstraints
} from './types/ApiResponse.type';

const axiosInstance = axios.create({
  baseURL: 'https://localhost:7268/api',
  headers: {
    'Content-type': 'application/json',
  },
});

const successfulResponseHandler = (response: AxiosResponse): Promise<ApiData<PayloadConstraints> | never> => response.data;
const errorResponseHandler = ({ response }: ApiAxiosError): Promise<ApiErrorResponse> => Promise.reject({
  message: response?.data.payload,
  status: response?.status
} as ApiErrorResponse);

axiosInstance.interceptors.response.use(successfulResponseHandler, errorResponseHandler);

export default axiosInstance;
