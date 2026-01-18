export interface PagedResult<T> {
  page: number;
  totalPages: number;
  totalItems: number;
  next?: string;
  prev?: string;
  results: T[];
}