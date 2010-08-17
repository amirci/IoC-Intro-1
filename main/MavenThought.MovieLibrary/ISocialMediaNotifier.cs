namespace MavenThought.MovieLibrary
{
    public interface ISocialMediaNotifier
    {
        /// <summary>
        /// Notifies a new movie has been added to the collection
        /// </summary>
        /// <param name="movie"></param>
        /// <param name="stars"></param>
        void Notify(IMovie movie, int stars);
    }
}