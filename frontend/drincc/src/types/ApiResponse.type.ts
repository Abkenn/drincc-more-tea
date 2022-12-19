import { AxiosError } from 'axios';
import { Dictionary } from './Dictionary.type';

export type PayloadConstraints = Dictionary | Array<Dictionary> | string | number | Array<string | number>;

export type ApiData<T extends PayloadConstraints> = { payload: T }

export type ApiResponse<T extends PayloadConstraints = never> = Promise<T extends never ? never : ApiData<T>>;

export type ApiAxiosError = AxiosError<ApiData<string>>;

export type ApiError = AxiosError | ApiErrorResponse;

export type ApiErrorResponse = {
  message?: string,
  status?: string
};
