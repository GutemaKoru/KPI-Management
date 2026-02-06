import { HttpClient } from '@angular/common/http';
import { Component, inject, OnInit, signal } from '@angular/core';

@Component({
  selector: 'app-root',
  imports: [],
  templateUrl: './app.html',
  styleUrl: './app.css',
})
export class App implements OnInit {
  private http = inject(HttpClient);
  protected perspectives = signal<any>([]);

  ngOnInit(): void {
    this.http.get('https://localhost:5001/api/perspectives').subscribe({
      next: (response) => this.perspectives.set(response),
      error: (error) => console.log(error),
      complete: () => console.log('Complete'),
    });
  }
}
