namespace MavenThought.MovieLibrary
{
    public interface IMovieCritic
    {
        /// <summary>
        /// Gets the rank of the movie
        /// </summary>
        /// <param name="movie"></param>
        /// <returns></returns>
        int Rate(IMovie movie);
    }
}