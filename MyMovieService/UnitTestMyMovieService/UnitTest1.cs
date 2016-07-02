using MyMovieService;
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Diagnostics;

namespace MyMovieService.Tests
{
    [TestClass()]
    public class UnitTest1
    {

        ImoviesDataService service = (ImoviesDataService)MovieServiceFactory.getMovieDataService(MovieServiceFactory.OMDB_API);
        Movie movie;

        
        [TestMethod]
        public void TestConstFactory()
        {
            Assert.IsNotNull(service);
        }

        
        [TestMethod]
        public void TestGetMovieName()
        {
            string testString = "The Boy";
            movie = service.GetMovieData(testString);
            Assert.AreEqual(testString, movie.Title);
        }
        
        [TestMethod]
        public void TestGetMovieYear()
        {
            string testString = "Toy Story";
            int year = 1995;
            movie= service.GetMovieData(testString);
            Assert.AreEqual(year, movie.Year);
        }

        [TestMethod]
        public void TestGetMovieLanguage()
        {
            string testString = "Toy Story";
            string language = "English";
            movie = service.GetMovieData(testString);
            Assert.AreEqual(language, movie.Language);
        }

        [TestMethod]
        public void TestGetMovieRuntime()
        {
            string testString = "Toy Story";
            string runtime = "81 min";
            movie = service.GetMovieData(testString);
            Assert.AreEqual(runtime, movie.Runtime);
        }

        [TestMethod]
        public void TestGetMovieCountry()
        {
            string testString = "Toy Story";
            string country = "USA";
            movie = service.GetMovieData(testString);
            Assert.AreEqual(country, movie.Country);
        }


        [TestMethod]
        public void TestGetMovieType()
        {
            string testString = "Toy Story";
            string type = "movie";
            movie = service.GetMovieData(testString);
            Assert.AreEqual(type, movie.Type);
        }

        [TestMethod]
        public void TestGetMovieRated()
        {
            string testString = "forrest gump";
            string rated = "PG-13";
            movie = service.GetMovieData(testString);
            Assert.AreEqual(rated, movie.Rated);
        }

        [TestMethod]
        public void TestGetMovieActors()
        {
            string testString = "forrest gump";
            string actors = "Tom Hanks, Rebecca Williams, Sally Field, Michael Conner Humphreys";
            movie = service.GetMovieData(testString);
            Assert.AreEqual(actors, movie.Actors);
        }

        [TestMethod]
        public void TestGetMovieIMDBRating()
        {
            string testString = "forrest gump";
            double imdbRate = 8.8;
            movie = service.GetMovieData(testString);
            Assert.AreEqual(imdbRate, movie.ImdbRating);
        }

        [TestMethod]
        public void TestGetMovieIMDBId()
        {
            string testString = "forrest gump";
            string  imdbId= "tt0109830";
            movie = service.GetMovieData(testString);
            Assert.AreEqual(imdbId, movie.ImdbID);
        }
    }
}

