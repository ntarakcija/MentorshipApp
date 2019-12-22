import { Component, OnInit, Input, Output, EventEmitter } from '@angular/core';
import { Product } from 'src/models/product.model';

@Component({
  selector: 'app-cart',
  templateUrl: './cart.component.html',
  styleUrls: ['./cart.component.css']
})
export class CartComponent implements OnInit {
  @Input()
  products;

  @Output()
  removeEmitter: EventEmitter<Product> = new EventEmitter<Product>();

  constructor() { }

  ngOnInit() {
  }

  remove(product: Product) {
    this.removeEmitter.emit(product);
  }
}
