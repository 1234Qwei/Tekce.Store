import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { kStringMaxLength } from 'buffer';
import { Observable } from 'rxjs';
import { DataSourceResult } from '../DataSource/DataSourceResult';
import { IServiceBase } from './IServiceBase';
var connectionString = '';
@Injectable({
  providedIn: 'root',
})
export abstract class ServiceBaseService<T> implements IServiceBase<T> {
  connectionString: string;
  constructor(public httpClient: HttpClient) {}
  getAll(): Observable<T[]> {
    return this.httpClient.get<T[]>(this.connectionString + 'getAll');
  }
  getById(id: number): Observable<T> {
    return this.httpClient.get<T>(this.connectionString + 'getbyid?id=' + id);
  }
  add(t: T): Observable<any> {
    return this.httpClient.post(this.connectionString, t, {
      responseType: 'text',
    });
  }
  update(t: T): Observable<any> {
    return this.httpClient.put(this.connectionString, t, {
      responseType: 'text',
    });
  }
  delete(id: number): Observable<any> {
    return this.httpClient.delete<T>(this.connectionString + '?id=' + id);
  }
  dataSource(): Observable<DataSourceResult<T>> {
    return this.httpClient.get<DataSourceResult<T>>(this.connectionString);
  }
}
