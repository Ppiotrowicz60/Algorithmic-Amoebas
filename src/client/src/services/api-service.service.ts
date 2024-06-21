import { HttpClient } from '@angular/common/http';
import { Injectable, signal } from '@angular/core';
import { environment } from '../environments/environment.development';

@Injectable()
export class ApiService {
  constructor(private http: HttpClient) {}

  callApi() {
    return this.http.get<string[]>(environment.apiUrl + '/example-list');
  }
}
