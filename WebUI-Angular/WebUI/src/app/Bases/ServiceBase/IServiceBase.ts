import { Observable } from 'rxjs';
import { DataSourceResult } from '../DataSource/DataSourceResult';

export interface IServiceBase<T> {
  getAll(): Observable<any>;
  getById(id: number): Observable<any>;
  add(t: T): Observable<any>;
  update(t: T): Observable<any>;
  delete(id: number): Observable<any>;
  dataSource(): Observable<DataSourceResult<T>>;
}
