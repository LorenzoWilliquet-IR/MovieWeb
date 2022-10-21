import { Component, OnInit } from '@angular/core';
import { MoviesService } from '../movies.service';

@Component({
  selector: 'app-movie-list',
  templateUrl: './movie-list.component.html',
  styleUrls: ['./movie-list.component.css']
})
export class MovieListComponent implements OnInit {

  movieArray: any[] = [];

  getMovies(): void {
    this.movieService.getMovies()
    .subscribe(movies => this.movieArray = movies);
  }

  constructor(private movieService: MoviesService) { }

  ngOnInit(): void {
    this.getMovies();
  }

}
