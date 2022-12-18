import { AxiosPromise } from 'axios';
import { Dictionary } from './Dictionary.type';

type PayloadConstraint = Dictionary | Array<Dictionary> | string | number | Array<string | number>;
type ApiPayload<T extends PayloadConstraint> = { payload: T }

export type ApiResponse<T extends PayloadConstraint = never> = AxiosPromise<T extends never ? never : ApiPayload<T>>;
