import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';

export interface ProductDto {
  id: number;
  name: string;
}

@Injectable({
  providedIn: 'root',
})
export class ProductsService {

  private readonly apiUrl = '/api/Products';

  constructor(private http: HttpClient) {}

  getAll(): Observable<ProductDto[]> {
    return this.http.get<ProductDto[]>(this.apiUrl);
  }
}
