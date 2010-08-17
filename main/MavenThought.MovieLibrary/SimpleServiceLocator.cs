using System;
using System.Collections.Generic;

namespace MavenThought.MovieLibrary
{
    /// <summary>
    /// Simple implementation of a service locator
    /// </summary>
    public class SimpleServiceLocator : IServiceLocator
    {
        /// <summary>
        /// Dictionary to store the instances
        /// </summary>
        private readonly IDictionary<Type, object> _serviceMap = new Dictionary<Type, object>();

        /// <summary>
        /// Gets the registered implementation of T
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public T GetService<T>()
        {
            return (T) this._serviceMap[typeof(T)];
        }

        /// <summary>
        /// Registers the implementation
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="implementation"></param>
        public void Register<T>(T implementation)
        {
            this._serviceMap[typeof(T)] = implementation;
        }
    }
}