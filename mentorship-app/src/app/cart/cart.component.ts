import { Component, OnInit, Input } from '@angular/core';
import { Product } from 'src/models/product.model';

@Component({
  selector: 'app-cart',
  templateUrl: './cart.component.html',
  styleUrls: ['./cart.component.css']
})
export class CartComponent implements OnInit {
  @Input()
  products: Product[];

  constructor() { }

  ngOnInit() {
  }

}
