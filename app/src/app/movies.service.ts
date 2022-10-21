import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Observable, of } from 'rxjs';
import { catchError, tap } from 'rxjs/operators';
@Injectable({
  providedIn: 'root'
})
export class MoviesService {
  private movieUrl = 'https://localhost:7144/api/movies';

  private handleError<T>(operation = 'operation', result?: T) {
    return (error: any): Observable<T> => {
  
      // TODO: send the error to remote logging infrastructure
      console.error(error); // log to console instead
  
      // TODO: better job of transforming error for user consumption
      console.log(`${operation} failed: ${error.message}`);
  
      // Let the app keep running by returning an empty result.
      return of(result as T);
    };
  }
  constructor(private http: HttpClient) { }

  httpOptions = {
    headers: new HttpHeaders({ 'Content-Type': 'application/json' })
  };
  // get movies as a list of movies
  getMovies(): Observable<any[]> {
    return this.http.get<any[]>(this.movieUrl)  
    .pipe(
      tap(_ => console.log('fetched heroes')),
      catchError(this.handleError<any[]>('getHeroes', []))
    );
  }

  // get single movie by id
  getMovie(id: number): Observable<any> {
    return this.http.get<any>(`${this.movieUrl}/${id}`)
    .pipe(
      tap(_ => console.log(`fetched movie #${id}`)),
      catchError(this.handleError<any[]>('getMovieById', []))
  );
}

/** DELETE: delete the hero from the server */
deleteHero(id: number): Observable<any> {
  const url = `${this.movieUrl}/${id}`;
  return this.http.delete<any>(url, this.httpOptions).pipe(
    tap(_ => console.log(`deleted hero id=${id}`)),
    catchError(this.handleError<any>('deleteHero'))
  );
}
// add a new movie
addMovie(movie: any): Observable<any> {
  const url = `${this.movieUrl}`;
  return this.http.post<any>(url, movie, this.httpOptions).pipe(
    tap(_ => console.log('added movie')),
    catchError(this.handleError<any>('addMovie'))
  );
}

// update a movie
updateMovie(movie: any): Observable<any> {
  const url = `${this.movieUrl}/${movie.id}`;
  return this.http.put<any>(url, movie, this.httpOptions).pipe(
    tap(_ => console.log(`updated hero id=${movie.id}`)),
    catchError(this.handleError<any>('updateMovie'))
  );
}
}
