using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyMovieService
{
    public class Movie
    {
        protected string title;
        protected int year;
        protected string rated;
        protected string released;
        protected string runtime;
        protected string genre;
        protected string director;
        protected string writer;
        protected string actors;
        protected string plot;
        protected string language;
        protected string country;
        protected string awards;
        protected string poster;
        protected int metascore;
        protected double imdbRating;
        protected string imdbVotes;
        protected string imdbID;
        protected string type;

         /// <summary> 
         /// Default constructor that initialize all the instance variable  
         /// </summary> 
         public Movie()
         { 
  
         }

        //=====================================================================
        /// <summary>
        /// Gets and Sets the title
        /// </summary>
        public string Title
        {
            get
            {
                return title;
            }
            set
            {
                if (value != null)
                    title = value;
                else
                    title = "";
            }
        }
        //=====================================================================
        /// <summary>
        /// Gets and Sets year
        /// </summary>
        public int Year
        {
            get
            {
                return year;
            }
            set
            {
                if (value < 0)
                    year = 0;
                else
                    year = value;
            }
        }
        //=====================================================================
        /// <summary>
        /// Gets and Sets rated
        /// </summary>
        public string Rated
        {
            get
            {
                return rated;
            }
            set
            {
                rated = value;
            }
        }
        //=====================================================================
        /// <summary>
        /// Gets and Sets rated
        /// </summary>
        public string Released
        {
            get
            {
                return released;
            }
            set
            {
                released = value;
            }
        }
        //=====================================================================
        /// <summary>
        /// Gets and Sets runtime
        /// </summary>
        public string Runtime
        {
            get
            {
                return runtime;
            }
            set
            {
                runtime = value;
            }
        }
        //=====================================================================
        /// <summary>
        /// Gets and Sets genre
        /// </summary>
        public string Genre
        {
            get
            {
                return genre;
            }
            set
            {
                genre = value;
            }
        }
        //=====================================================================
        /// <summary>
        /// Gets and Sets genre
        /// </summary>
        public string Director
        {
            get
            {
                return director;
            }
            set
            {
                director = value;
            }
        }
        //=====================================================================
        /// <summary>
        /// Gets and Sets writer
        /// </summary>
        public string Writer
        {
            get
            {
                return writer;
            }
            set
            {
                writer = value;
            }
        }
        //=====================================================================
        /// <summary>
        /// Gets and Sets writer
        /// </summary>
        public string Actors
        {
            get
            {
                return actors;
            }
            set
            {
                actors = value;
            }
        }
        //=====================================================================
        /// <summary>
        /// Gets and Sets plot
        /// </summary>
        public string Plot
        {
            get
            {
                return plot;
            }
            set
            {
                plot = value;
            }
        }
        //=====================================================================
        /// <summary>
        /// Gets and Sets language
        /// </summary>
        public string Language
        {
            get
            {
                return language;
            }
            set
            {
                language = value;
            }
        }
        //=====================================================================
        /// <summary>
        /// Gets and Sets country
        /// </summary>
        public string Country
        {
            get
            {
                return country;
            }
            set
            {
                country = value;
            }
        }
        //=====================================================================
        /// <summary>
        /// Gets and Sets country
        /// </summary>
        public string Awards
        {
            get
            {
                return awards;
            }
            set
            {
                awards = value;
            }
        }
        //=====================================================================
        /// <summary>
        /// Gets and Sets poster
        /// </summary>
        public string Poster
        {
            get
            {
                return poster;
            }
            set
            {
                poster = value;
            }
        }
        //=====================================================================
        /// <summary>
        /// Gets and Sets poster
        /// </summary>
        public int Metascore
        {
            get
            {
                return metascore;
            }
            set
            {
                metascore = value;
            }
        }
        //=====================================================================
        /// <summary>
        /// Gets and Sets poster
        /// </summary>
        public double ImdbRating
        {
            get
            {
                return imdbRating;
            }
            set
            {
                imdbRating = value;
            }
        }
        //=====================================================================
        /// <summary>
        /// Gets and Sets poster
        /// </summary>
        public string ImdbVotes
        {
            get
            {
                return imdbVotes;
            }
            set
            {
                imdbVotes = value;
            }
        }
        //=====================================================================
        /// <summary>
        /// Gets and Sets poster
        /// </summary>
        public string ImdbID
        {
            get
            {
                return imdbID;
            }
            set
            {
                imdbID = value;
            }
        }
        //=====================================================================
        /// <summary>
        /// Gets and Sets poster
        /// </summary>
        public string Type
        {
            get
            {
                return type;
            }
            set
            {
                type = value;
            }
        }
        
    }
}
