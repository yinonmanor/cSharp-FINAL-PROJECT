using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace MyMovieService
{
    public class MoviesDataSite : Movie, ImoviesDataService
    {
        private static MoviesDataSite moviedata;
        private MoviesDataSite() : base() { }

        /// <summary> 
        /// A method that implements singleton Design Pattern that creates 
        ///  only 1 object. 
        /// </summary> 
        /// <returns>return a WeatherData object in type of WeatherDatasite1</returns> 
        /// 
        public static MoviesDataSite Instance()
        {
            if (moviedata == null)
            {
                moviedata = new MoviesDataSite();
            }
            return moviedata;
        }

        public Movie GetMovieData(string movieName)
        {
            //MoviesDataSite movie = new MoviesDataSite();
            Movie movie = new Movie();
            try
            {
                movie = XMLFunction(movieName);
            }
            catch (MovieServiceException ex)
            {
                return null;
            }
            return movie;
        }

        public Movie XMLFunction(string movieName)
        {
            string URLString = "http://www.omdbapi.com/?t=" + movieName.Trim() + "&r=xml";
            string xml;
            using (WebClient client = new WebClient())
            {
                try
                {
                    xml = client.DownloadString(URLString);// xml url to string
                }
                catch (WebException)
                {
                    throw new MovieServiceException("There is not internet connection");
                }
            }
            try
            {
                MoviesDataSite MyMovie = new MoviesDataSite();
                XDocument ob = XDocument.Parse(xml);
                //A linq to xml that get all the values from the site
                var movie = from x in ob.Descendants("root")
                            select new
                            {
                                title = x.Descendants("movie").Attributes("title").First().Value,
                                year = x.Descendants("movie").Attributes("year").First().Value,
                                rated = x.Descendants("movie").Attributes("rated").First().Value,
                                released = x.Descendants("movie").Attributes("released").First().Value,
                                runtime = x.Descendants("movie").Attributes("runtime").First().Value,
                                genre = x.Descendants("movie").Attributes("genre").First().Value,
                                director = x.Descendants("movie").Attributes("director").First().Value,
                                writer = x.Descendants("movie").Attributes("writer").First().Value,
                                actors = x.Descendants("movie").Attributes("actors").First().Value,
                                plot = x.Descendants("movie").Attributes("plot").First().Value,
                                language = x.Descendants("movie").Attributes("language").First().Value,
                                country = x.Descendants("movie").Attributes("country").First().Value,
                                awards = x.Descendants("movie").Attributes("awards").First().Value,
                                poster = x.Descendants("movie").Attributes("poster").First().Value,
                                metascore = x.Descendants("movie").Attributes("metascore").First().Value,
                                imdbRating = x.Descendants("movie").Attributes("imdbRating").First().Value,
                                imdbVotes = x.Descendants("movie").Attributes("imdbVotes").First().Value,
                                imdbID = x.Descendants("movie").Attributes("imdbID").First().Value,
                                type = x.Descendants("movie").Attributes("type").First().Value,
                            };
                //Get all the values from the linq vairables and set  
                //them into the WeatherData service values. 
                foreach (var data in movie)
                {
                    MyMovie.Title= data.title;
                    MyMovie.Year = int.Parse(data.year);
                    MyMovie.Rated = data.rated;
                    MyMovie.Released = data.released;
                    MyMovie.Runtime = data.runtime;
                    MyMovie.Genre = data.genre;
                    MyMovie.Director = data.director;
                    MyMovie.Writer = data.writer;
                    MyMovie.Actors = data.actors;
                    MyMovie.Plot = data.plot;
                    MyMovie.Language = data.language;
                    MyMovie.Country = data.country;
                    MyMovie.Awards = data.awards;
                    MyMovie.Poster = data.poster;
                    MyMovie.Metascore = int.Parse(data.metascore);
                    MyMovie.ImdbRating = double.Parse(data.imdbRating);
                    MyMovie.ImdbVotes = data.imdbVotes;
                    MyMovie.ImdbID = data.imdbID;
                    MyMovie.Type = data.type;
                }
                return MyMovie;
            }

            catch (XmlException ex)
            {
                throw new MovieServiceException("Wrong Movie entered");
            }
            catch (WebException ex)
            {
                throw new MovieServiceException("There is not internet connection");
            }
        }
    }
}
