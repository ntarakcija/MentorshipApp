import { ProductCategory } from './product-category.enum';

export class Product {
    id: string;
    name: string;
    description: string;
    price: number;
    category: ProductCategory;
}
