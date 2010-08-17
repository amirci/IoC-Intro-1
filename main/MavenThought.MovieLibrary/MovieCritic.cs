using System;

namespace MavenThought.MovieLibrary
{
    /// <summary>
    /// Critic to rank movies
    /// </summary>
    public class MovieCritic : IMovieCritic
    {
        /// <summary>
        /// Gets the rank of the movie
        /// </summary>
        /// <param name="movie"></param>
        /// <returns></returns>
        public int Rate(IMovie movie)
        {
            return 0;
        }
    }
}