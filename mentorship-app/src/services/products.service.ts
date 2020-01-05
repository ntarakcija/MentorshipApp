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

  getProduct(id: string) {
    return this.httpClient.get('https://localhost:5001/api/products/' + id);
  }

  getCart() {
    return this.httpClient.get('https://localhost:5001/api/products/cart');
  }

  addToCart(id: string) {
    return this.httpClient.post('https://localhost:5001/api/products/cart/' + id, {});
  }

  removeFromCart(id: string) {
    return this.httpClient.delete('https://localhost:5001/api/products/cart/' + id);
  }

  getPrice() {
    return this.httpClient.get('https://localhost:5001/api/products/cart/price');
  }

  getDiscount() {
    return this.httpClient.get('https://localhost:5001/api/products/cart/discount');
  }
}
