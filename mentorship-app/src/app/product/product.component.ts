import { Component, OnInit, Input, Output, EventEmitter } from '@angular/core';
import { Product } from 'src/models/product.model';

@Component({
  selector: 'app-product',
  templateUrl: './product.component.html',
  styleUrls: ['./product.component.css']
})
export class ProductComponent implements OnInit {
  @Input()
  product: Product;

  @Output()
  deleteEmitter: EventEmitter<void> = new EventEmitter<void>();

  @Output()
  addToCartEmitter: EventEmitter<void> = new EventEmitter<void>();

  constructor() { }

  ngOnInit() {
  }

  delete() {
    this.deleteEmitter.emit();
  }

  addToCart() {
    this.addToCartEmitter.emit();
  }
}
