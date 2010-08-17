using System;
using MbUnit.Framework;
using Rhino.Mocks;
using MavenThought.Commons.Testing;
using SharpTestsEx;

namespace MavenThought.MovieLibrary.Tests
{
    /// <summary>
    /// Specification when ...
    /// </summary>
    [Specification]
    public class When_service_locator_resolves_type : BaseSpecification
    {
        private IDontKnow _actual;

        /// <summary>
        /// Checks the instance returned is the expected one
        /// </summary>
        [Test]
        public void Should_return_the_expected_instance()
        {
            this._actual.Should().Be.InstanceOf<NotSure>();
        }

        /// <summary>
        /// Setup the service locator
        /// </summary>
        protected override void GivenThat()
        {
            base.GivenThat();

            var srv = new SimpleServiceLocator();

            srv.Register<IDontKnow>(new NotSure());

            ServiceLocator.Initialize(srv);
        }

        /// <summary>
        /// Get the service
        /// </summary>
        protected override void WhenIRun()
        {
            this._actual = ServiceLocator.GetService<IDontKnow>();
        }
    }
}