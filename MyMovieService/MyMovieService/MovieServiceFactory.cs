using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyMovieService
{
    public class MovieServiceFactory
    {
        
        public static string OMDB_API = "OMDB_API";
 
         
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
