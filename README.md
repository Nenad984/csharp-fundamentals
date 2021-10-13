[![Gitpod ready-to-code](https://img.shields.io/badge/Gitpod-ready--to--code-blue?logo=gitpod)](https://gitpod.io/#https://github.com/Nenad984/csharp-fundamentals)

[![CodeFactor](https://www.codefactor.io/repository/github/nenad984/csharp-fundamentals/badge)](https://www.codefactor.io/repository/github/nenad984/csharp-fundamentals)


### Usage - Interfaces
The following interfaces can be used to retrieve information:
* [`IApiConfigurationRequest`](DM.MovieApi/MovieDb/Configuration/IApiConfigurationRequest.cs): Provides access for retrieving themoviedb.org configuration information.
* [`IApiMovieRequest`](DM.MovieApi/MovieDb/Movies/IApiMovieRequest.cs): Provides access for retrieving information about Movies.
* [`IApiMovieRatingRequest`](DM.MovieApi/MovieDb/Certifications/IApiMovieRatingRequest.cs): Provides access for retrieving movie rating information.
* [`IApiTVShowRequest`](DM.MovieApi/MovieDb/TV/IApiTVShowRequest.cs): Provides access for retrieving information about TV shows.
* [`IApiGenreRequest`](DM.MovieApi/MovieDb/Genres/IApiGenreRequest.cs): Provides access for retrieving Movie and TV genres.
* [`IApiCompanyRequest`](DM.MovieApi/MovieDb/Companies/IApiCompanyRequest.cs): Provides access for retrieving production company information.
* [`IApiProfessionRequest`](DM.MovieApi/MovieDb/IndustryProfessions/IApiProfessionRequest.cs): Provides access for retrieving information about Movie/TV industry specific professions.
* [`IApiPeopleRequest`](DM.MovieApi/MovieDb/People/IApiPeopleRequest.cs): Provides access for retrieving information about People.

### Usage - Examples
Register your settings first:
```csharp
// registration with an implementation of IMovieDbSettings
//, i.e., public class YourMovieDbSettings : IMoveDbSettings { // implementation }
MovieDbFactory.RegisterSettings( new YourMovieDbSettings() )

// alternative method of registration
MovieDbFactory.RegisterSettings( "your-apiKey", "https://api.themoviedb.org/3/" )
```
