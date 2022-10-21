import { Component, OnInit } from '@angular/core';
import { MoviesService } from '../movies.service';

@Component({
  selector: 'app-movie-list',
  templateUrl: './movie-list.component.html',
  styleUrls: ['./movie-list.component.css']
})
export class MovieListComponent implements OnInit {

  movieArray: any[] = [];
  selectedHero?: any;
  getMovies(): void {
    this.movieService.getMovies()
    .subscribe(movies => this.movieArray = movies);
  }
  // add movies
  addMovie(): void {
    this.movieService.addMovie(this.selectedHero)
   .subscribe(() => {
      this.movieArray.push(this.selectedHero);
      this.selectedHero = undefined;
    });
  }

  constructor(private movieService: MoviesService) { }

  ngOnInit(): void {
    this.getMovies();
   // this.movieArray
  }
  
  onSelect(movie: any): void {
    this.selectedHero = movie;
  }

}
