import { DealsService } from './../../services/deals.service';
import { Component, OnInit } from '@angular/core';
import { Deal } from 'src/models/deal.model';

@Component({
  selector: 'app-deals',
  templateUrl: './deals.component.html',
  styleUrls: ['./deals.component.css']
})
export class DealsComponent implements OnInit {
  deals: Deal[];

  constructor(private dealsService: DealsService) { }

  ngOnInit() {
    this.getDeals();
  }

  getDeals() {
    this.dealsService.getDeals().subscribe((data: Deal[]) => this.deals = data);
  }

  createDeal(category: number) {
    this.dealsService.createDeal(category).subscribe(data => this.getDeals());
  }
}
