import { Component, OnInit, Input, Output, EventEmitter } from '@angular/core';
import { Product } from 'src/models/product.model';
import { ProductsService } from 'src/services/products.service';

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

  price: number;
  discount: number;

  constructor(private productsService: ProductsService) { }

  ngOnInit() {
  }

  remove(product: Product) {
    this.removeEmitter.emit(product);
  }

  getPrice() {
    this.productsService.getPrice().subscribe((data: number) => {
      this.price = data;
    });
  }

  getDiscount() {
    this.productsService.getDiscount().subscribe((data: number) => {
      this.discount = data;
    });
  }
}
