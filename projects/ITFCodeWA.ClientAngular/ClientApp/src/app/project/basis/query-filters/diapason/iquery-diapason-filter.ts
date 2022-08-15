import { IQueryFilter } from "../iquery-filter";

export interface IQueryDiapasonFilter<TValue> extends IQueryFilter {
  from: TValue;
  to: TValue;
}
