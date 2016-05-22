using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyMovieService
{
    class MovieServiceFactory
    {
        /// <summary> 
        /// use http://www.omdbapi.com REStful Web Service. 
        /// </summary> 
        public static string OPEN_WEATHER_MAP = "OMDB_API";
 
         /// <summary> 
         /// This method get from the user the web service that he want 
         /// to create an object, and create a singleton object. 
         /// </summary> 
         /// <param name="str">The desired service.</param> 
         /// <returns>Return an object from the type of the chosen REStful Web Service.</returns> 
         public static Movie getMovieDataService(string str)
         {
            Movie movie = null; 
 
 
             if (str.Equals("OMDB_API"))          
             {
                movie = MoviesDataSite.Instance();
             } 
             //else if (str.Equals("WORLD_WEATHER_ONLINE"))              
             //{ 
             //    wd = WeatherDataSite2.Instance(); 
             //} 
 

             return movie;
         } 

    }
}
