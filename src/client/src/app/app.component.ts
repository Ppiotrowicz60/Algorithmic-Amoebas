import { HttpClient } from '@angular/common/http';
import { ApiService } from './../services/api-service.service';
import { Component, OnInit, Signal, signal } from '@angular/core';
import { RouterOutlet } from '@angular/router';

@Component({
  selector: 'app-root',
  standalone: true,
  imports: [RouterOutlet],
  providers: [HttpClient, ApiService],
  templateUrl: './app.component.html',
  styleUrl: './app.component.scss',
})
export class AppComponent {
  response = signal<string[]>([]);

  constructor(public apiService: ApiService) {}

  callApi() {
    this.apiService.callApi().subscribe((value) => this.response.set(value));
  }
}
