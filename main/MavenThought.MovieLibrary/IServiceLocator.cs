namespace MavenThought.MovieLibrary
{
    /// <summary>
    /// Finds services implementation
    /// </summary>
    public interface IServiceLocator
    {
        /// <summary>
        /// Gets the registered implementation of T
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        T GetService<T>();
    }
}