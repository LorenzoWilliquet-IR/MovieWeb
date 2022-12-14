import { MoviesService } from './../movies.service';
import { Component, OnInit, Input } from '@angular/core';
import { Location } from '@angular/common';
import { ActivatedRoute } from '@angular/router';

@Component({
  selector: 'app-movie-details',
  templateUrl: './movie-details.component.html',
  styleUrls: ['./movie-details.component.css']
})
export class MovieDetailsComponent implements OnInit {
  @Input() movie: any;

  constructor(
      private location: Location,
      private route: ActivatedRoute,
      private movieService: MoviesService) { }

  // get movie 
  getMovie() {
    const id = Number(this.route.snapshot.paramMap.get('id'));
    this.movieService.getMovie(id).subscribe(movie => {
      this.movie = movie;
    });
  }

  // delete a movie 
  deleteMovie() {
    const id = Number(this.route.snapshot.paramMap.get('id'));
    this.movieService.deleteMovie(id).subscribe(movie => {
      this.movie = movie;
      this.location.back();
    })
  }
  ngOnInit(): void {
    this.getMovie();
  }

  goBack(): void {
    this.location.back();
  }

}
