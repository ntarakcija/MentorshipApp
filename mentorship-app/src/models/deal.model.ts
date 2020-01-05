import { DealCategory } from './deal-category.enum';
import { Product } from './product.model';

export class Deal {
    id: string;
    name: string;
    price: number;
    description: string;
    category: DealCategory;
    items: Product[];
}
