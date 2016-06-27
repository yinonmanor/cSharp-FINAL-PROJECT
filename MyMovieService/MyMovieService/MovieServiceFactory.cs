﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyMovieService
{
    public class MovieServiceFactory
    {
        /// <summary> 
        /// use http://www.omdbapi.com REStful Web Service. 
        /// </summary> 
        public static string OMDB_API = "OMDB_API";
 
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
            return movie;
         } 

    }
}
