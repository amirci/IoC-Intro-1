namespace MavenThought.MovieLibrary
{
    /// <summary>
    /// Notification for movie events
    /// </summary>
    public class TwitterNotifier : ISocialMediaNotifier
    {
        /// <summary>
        /// Notifies a new movie has been added to the collection
        /// </summary>
        /// <param name="movie"></param>
        /// <param name="stars"></param>
        public void Notify(IMovie movie, int stars)
        {            
        }
    }
}