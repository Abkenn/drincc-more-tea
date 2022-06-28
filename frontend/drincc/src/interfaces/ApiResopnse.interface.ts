import { Dictionary } from '../types/Dictionary.type';

export interface ApiResponse {
  data: { payload: Dictionary | Array<Dictionary> | string | number | Array<string | number> };
}