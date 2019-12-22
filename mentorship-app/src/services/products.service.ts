import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http'

@Injectable({
  providedIn: 'root'
})
export class ProductsService {

  constructor(private httpClient: HttpClient) { }

  getProducts() {
    return this.httpClient.get('https://localhost:5001/api/products');
  }

  getProduct(id: number) {
    return this.httpClient.get('https://localhost:5001/api/products/' + id);
  }

  deleteProduct(id: number) {
    return this.httpClient.delete('https://localhost:5001/api/products/' + id);
  }
}
