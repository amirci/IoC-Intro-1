using System.Collections.Generic;

namespace MavenThought.MovieLibrary
{
    /// <summary>
    /// Library to store media
    /// </summary>
    public class MovieLibrary
    {
        /// <summary>
        /// Notifier instance
        /// </summary>
        private readonly ISocialMediaNotifier _notifier;

        /// <summary>
        /// Gets the critics associated to the library
        /// </summary>
        private readonly IMovieCritic _critic;

        /// <summary>
        /// Collection to store the movies
        /// </summary>
        private readonly ICollection<IMovie> _contents = new List<IMovie>();

        /// <summary>
        /// Initializes a new instance of <see cref="MovieLibrary"/> class.
        /// </summary>
        public MovieLibrary()
            : this(ServiceLocator.GetService<IMovieCritic>(), 
                   ServiceLocator.GetService<ISocialMediaNotifier>())
        {            
        }

        /// <summary>
        /// Initializes a new instance of <see cref="MovieLibrary"/> injecting the critic and social notifier
        /// </summary>
        /// <param name="critic">Critic to use</param>
        /// <param name="notifier">Notifier to use</param>
        public MovieLibrary(IMovieCritic critic, ISocialMediaNotifier notifier)
        {
            this._critic = critic;
            this._notifier = notifier;
        }

        /// <summary>
        /// Gets the Contents of the library
        /// </summary>
        public IEnumerable<IMovie> Contents
        {
            get { return this._contents; }
        }

        /// <summary>
        /// Adds a movie to the library
        /// </summary>
        /// <param name="movie">Movie to add</param>
        public void Add(IMovie movie)
        {
            var stars = this._critic.Rate(movie);

            if (stars > 2)
            {
                this._contents.Add(movie);
                this._notifier.Notify(movie, stars);
            }
        }
    }
}