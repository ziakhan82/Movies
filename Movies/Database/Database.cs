using Movies.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Movies
{
    public class Database
    {
        private List<Movie> movies = new List<Movie>
        {
            new Movie{Id=1,Title="haha",Year=1999,RunningTimeInMin=200,StudioId=1 }

        };
        private List<Studio> Studios = new List<Studio>
        {
            new Studio{Id=1,Name="Zia",HQCity="copenhagen",NoOfEmployee=11 } };




    }
}
