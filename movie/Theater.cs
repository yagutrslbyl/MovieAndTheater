using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace movie
{
    internal class Theater:Base

    {
        private int idCounter = 0;
        public Movie[] _movies = new Movie[0];
        public Theater(string name):base(name)
        {
            ID = idCounter++;   
        }
        public void AddMovie(Movie movie)
        {
            bool isexist = false;
            for (int i = 0; i < _movies.Length; i++)
                if (movie == _movies[i])
                {
                    Console.WriteLine("This movie is in Theater already!");
                    isexist = true;
                    break;
                }

            if (isexist)
            { Console.WriteLine("This movie is already in Theater!"); }
            else
            {
                Movie[] newMovie = new Movie[_movies.Length + 1];
                for (int j = 0; j < _movies.Length; j++)
                {
                    newMovie[j] = _movies[j];
                }
                newMovie[^1] = movie;
                Console.WriteLine("Movie added");
                _movies = newMovie;
            }



        }
        public void ListAllMovies()
        {
            foreach(Movie movie in _movies)
            {
                Console.WriteLine(movie);
            }
        }

        public void RemoveMovie(Movie movie)
        {
            int index = -1;
            for(int i=0; i < _movies.Length; i++)
            {
                if (movie == _movies[i])
                {
                    index = i;
                    break;
                }
            }
            if (index == -1)
            {
                Console.WriteLine("There is no movie like that.");
            }
            else
            {
                Movie[] newMovies = new Movie[_movies.Length - 1];
                int i = 0;
                for (int j = 0; j < _movies.Length; j--)
                {
                    if (index != j)
                    {
                        newMovies[i] = _movies[j];
                        i++;
                    }
                }
                _movies = newMovies;
            }
        }
    }
}
