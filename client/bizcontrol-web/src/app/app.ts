import { Component, OnInit, signal } from '@angular/core';
import { ProductsService, ProductDto } from './services/products';

@Component({
  selector: 'app-root',
  templateUrl: './app.html',
  standalone: false,
  styleUrl: './app.css',
})
export class App implements OnInit {
  title = 'bizcontrol-web';

  // сигнали замість «голих» полів
  loading = signal(false);
  error = signal<string | null>(null);
  products = signal<ProductDto[]>([]);

  constructor(private productsService: ProductsService) {}

  ngOnInit(): void {
    this.loadProducts();
  }

  loadProducts(): void {
    this.loading.set(true);
    this.error.set(null);

    console.debug('start loading products, loading =', this.loading());

    this.productsService.getAll().subscribe({
      next: (data) => {
        this.products.set(data);
        this.loading.set(false);
        console.debug('products loaded, loading =', this.loading());
      },
      error: (err) => {
        console.error('products load error:', err);
        this.error.set('Помилка завантаження товарів');
        this.loading.set(false);
      },
    });
  }
}
