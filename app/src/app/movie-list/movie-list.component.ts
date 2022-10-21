import { Component, OnInit } from '@angular/core';
import { MoviesService } from '../movies.service';

@Component({
  selector: 'app-movie-list',
  templateUrl: './movie-list.component.html',
  styleUrls: ['./movie-list.component.css']
})
export class MovieListComponent implements OnInit {
  MOVIES: any[] = [
    { id: 12, name: 'Dr. Nice' },
    { id: 13, name: 'Bombasto' },
    { id: 14, name: 'Celeritas' },
    { id: 15, name: 'Magneta' },
    { id: 16, name: 'RubberMan' },
    { id: 17, name: 'Dynama' },
    { id: 18, name: 'Dr. IQ' },
    { id: 19, name: 'Magma' },
    { id: 20, name: 'Tornado' }
  ];
  movieArray: any[] = this.MOVIES;
  selectedHero?: any;
  getMovies(): void {
    this.movieService.getMovies()
    .subscribe(movies => this.movieArray = movies);
  }

  constructor(private movieService: MoviesService) { }

  ngOnInit(): void {
    //this.getMovies();
    this.movieArray
  }
  
  onSelect(movie: any): void {
    this.selectedHero = movie;
  }

}
