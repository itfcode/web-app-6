import { IQueryFilter } from "./iquery-filter";

export interface IQueryOptions {
  sortField: string
  isAsc: boolean;
  take: number;
  skip: number;
  filters: IQueryFilter[];
}
