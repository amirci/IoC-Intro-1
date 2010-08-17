using MbUnit.Framework;
using MavenThought.Commons.Testing;
using SharpTestsEx;

namespace MavenThought.MovieLibrary.Tests
{
    /// <summary>
    /// Specification when resolving type
    /// </summary>
    [Specification]
    public class When_simple_service_locator_resolves_type : BaseSpecification
    {
        private IDontKnow _actual;

        /// <summary>
        /// Gets or sets the SUT
        /// </summary>
        protected SimpleServiceLocator Sut { get; set; }

        /// <summary>
        /// Checks the instance is the expected
        /// </summary>
        [Test]
        public void Should_return_the_expected_instance()
        {
            this._actual.Should().Be.InstanceOf<NotSure>();
        }

        /// <summary>
        /// Setup the SUT and dependencies
        /// </summary>
        protected override void GivenThat()
        {
            base.GivenThat();

            this.Sut = new SimpleServiceLocator();

            this.Sut.Register<IDontKnow>(new NotSure());
        }

        /// <summary>
        /// Get the service
        /// </summary>
        protected override void WhenIRun()
        {
            this._actual = this.Sut.GetService<IDontKnow>();
        }
    }

    internal class NotSure : IDontKnow
    {
    }

    internal interface IDontKnow {}
}