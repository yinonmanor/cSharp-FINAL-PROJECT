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

        /// <summary>
        /// This method check if the web service is support the Const value.
        /// </summary>
        [TestMethod]
        public void TestConstFactory()
        {
            Assert.IsNotNull(service);
        }

        /// <summary>
        /// Check that that the return name of the movie return is what wi send
        /// </summary>
        [TestMethod]
        public void TestGetMovieName()
        {
            string testString = "The Boy";
            movie = service.GetMovieData("The Boy");
            Assert.AreEqual(testString, movie.Title);
        }

        /// <summary>
        /// Disconnect the internet in order to throw an excetion ( WebException )
        /// and check if there is a fail.
        /// </summary>
        [TestMethod]
        public void TestXMLInternet()
        {
            ProcessStartInfo info = new ProcessStartInfo();
            info.FileName = "ipconfig";
            info.Arguments = "/release"; // or /release if you want to disconnect
            info.WindowStyle = ProcessWindowStyle.Hidden;
            Process p = Process.Start(info);
            p.WaitForExit();

            Movie movie = service.GetMovieData("The Boy");

            info.Arguments = "/renew";
            p = Process.Start(info);

            Assert.AreNotEqual(null, movie.Title);
        }
    }
}

