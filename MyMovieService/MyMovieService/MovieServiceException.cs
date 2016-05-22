using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyMovieService
{
    class MovieServiceException : ApplicationException
    {
        /// <summary> 
        /// A constructor that get a message from throw an exception.  
        /// </summary> 
        /// <param name="message">Describes the message of the exception</param> 
        public MovieServiceException(String message) : base(message) 
        { 
              
        } 

    }
}
