[![Gitpod ready-to-code](https://img.shields.io/badge/Gitpod-ready--to--code-blue?logo=gitpod)](https://gitpod.io/#https://github.com/Nenad984/csharp-fundamentals)

[![CodeFactor](https://www.codefactor.io/repository/github/nenad984/csharp-fundamentals/badge)](https://www.codefactor.io/repository/github/nenad984/csharp-fundamentals)

``` javascript 
// registration with an implementation of IMovieDbSettings
//, i.e., public class YourMovieDbSettings : IMoveDbSettings { // implementation }
MovieDbFactory.RegisterSettings( new YourMovieDbSettings() )

// alternative method of registration
MovieDbFactory.RegisterSettings( "your-apiKey", "https://api.themoviedb.org/3/" )

```
