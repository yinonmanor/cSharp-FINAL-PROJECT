using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyMovieService
{
    interface ImoviesDataService
    {
        Movie GetMovieData(string movieName);
    }
}
