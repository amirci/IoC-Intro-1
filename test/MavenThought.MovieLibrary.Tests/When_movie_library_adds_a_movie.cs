using System;
using MavenThought.Commons.Testing;
using MbUnit.Framework;
using SharpTestsEx;

namespace MavenThought.MovieLibrary.Tests
{
    /// <summary>
    /// Specification when adding a movie to the library
    /// </summary>
    [Specification]
    public class When_movie_library_adds_a_movie : BaseSpecification
    {
        /// <summary>
        /// Movie to use
        /// </summary>
        private IMovie _movie;

        private IMovieCritic _critic;

        private MockSocialMediaNotifier _notifier;

        /// <summary>
        /// Gets or sets the system under test
        /// </summary>
        protected MovieLibrary Sut { get; set; }

        /// <summary>
        /// Checks the movie has been added
        /// </summary>
        [Test]
        public void Should_include_the_movie_in_the_contents()
        {
            this.Sut.Contents.Should().Contain(this._movie);
        }

        /// <summary>
        /// Checks the notifier is called
        /// </summary>
        [Test]
        public void Should_notify_to_the_social_media()
        {
            this._notifier.Movie.Should().Be.InstanceOf<MockMovie>();

            this._notifier.Stars.Should().Be.EqualTo(5);
        }
        
        /// <summary>
        /// Setup the movie
        /// </summary>
        protected override void GivenThat()
        {
            base.GivenThat();

            // Create all the dependencies
            this._critic = new MockMovieCritic();

            this._notifier = new MockSocialMediaNotifier();

            // Initialize the SUT
            this.Sut = new MovieLibrary(this._critic, this._notifier);
            
            this._movie = new MockMovie();
        }

        /// <summary>
        /// Add the movie
        /// </summary>
        protected override void WhenIRun()
        {
            this.Sut.Add(this._movie);
        }
    }

    internal class MockMovie : IMovie
    {
        /// <summary>
        /// Title of the movie
        /// </summary>
        public string Title
        {
            get { return string.Empty; }
        }

        /// <summary>
        /// Release date of the movie
        /// </summary>
        public DateTime? ReleaseDate
        {
            get { return null; }
        }
    }

    internal class MockSocialMediaNotifier : ISocialMediaNotifier
    {
        /// <summary>
        /// Notifies a new movie has been added to the collection
        /// </summary>
        /// <param name="movie"></param>
        /// <param name="stars"></param>
        public void Notify(IMovie movie, int stars)
        {
            this.Movie = movie;
            this.Stars = stars;
        }

        public IMovie Movie { get; set; }

        public int Stars { get; set; }
    }

    internal class MockMovieCritic : IMovieCritic
    {
        /// <summary>
        /// Gets the rank of the movie
        /// </summary>
        /// <param name="movie"></param>
        /// <returns></returns>
        public int Rate(IMovie movie)
        {
            return 5;
        }
    }
}