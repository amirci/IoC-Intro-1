using System;

namespace MavenThought.MovieLibrary
{
    /// <summary>
    /// Global access to service locator service
    /// </summary>
    public class ServiceLocator
    {
        private static IServiceLocator _serviceLocator;

        /// <summary>
        /// Gets the service matching the type
        /// </summary>
        /// <typeparam name="T">Type to use</typeparam>
        /// <returns></returns>
        public static T GetService<T>()
        {
            return _serviceLocator.GetService<T>();
        }

        /// <summary>
        /// Initializes the service locator with the implementation
        /// </summary>
        /// <param name="serviceLocator"></param>
        public static void Initialize(IServiceLocator serviceLocator)
        {
            _serviceLocator = serviceLocator;
        }
    }
}