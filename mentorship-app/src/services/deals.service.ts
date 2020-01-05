import { DealCategory } from './../models/deal-category.enum';
import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})
export class DealsService {

  constructor(private httpClient: HttpClient) { }

  getDeals() {
    return this.httpClient.get('https://localhost:5001/api/deals');
  }

  createDeal(category: DealCategory) {
    return this.httpClient.post('https://localhost:5001/api/deals/' + category, {});
  }
}
