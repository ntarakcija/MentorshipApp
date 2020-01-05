import { Component, OnInit } from '@angular/core';
import { ProductsService } from 'src/services/products.service';
import { Product } from 'src/models/product.model';

@Component({
  selector: 'app-products',
  templateUrl: './products.component.html',
  styleUrls: ['./products.component.css']
})
export class ProductsComponent implements OnInit {
  products: Product[] = [];
  cartProducts: { product: Product, count: number }[] = [];
  cart: Product[] = [];

  constructor(private productsService: ProductsService) { }

  ngOnInit() {
    this.getProducts();
    this.getCart();
  }

  getProducts() {
    this.productsService.getProducts().subscribe((data: Product[]) => {
      this.products = data;
    });
  }

  getCart() {
    this.productsService.getCart().subscribe((data: Product[]) => {
      this.cart = data;
    });
  }

  addToCart(product: Product) {
    this.productsService.addToCart(product.id).subscribe(data => {
      this.getCart();
    });
  }

  removeFromCart(product: Product) {
    this.productsService.removeFromCart(product.id).subscribe(data => {
      this.getCart();
    });
  }

  /* addToCart(product: Product) {
    const index = this.cartProducts.findIndex(item => item.product.id === product.id);

    if (index === -1) {
      this.cartProducts.push({
        product,
        count: 1
      });
    } else {
      this.cartProducts[index].count++;
    }
  }

  removeFromCart(event: Product) {
    this.cartProducts = this.cartProducts.filter(item => item.product.id !== event.id);
  } */
}
