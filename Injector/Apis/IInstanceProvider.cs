using System;
namespace IocContainer.Binder
{
    public interface IInstanceProvider
    {
        /// <summary>
        ///     Retrieve an Instance based on the key.
        ///     ex. `injectionBinder.Get<cISomeInterface>();`
        /// </summary>
        T GetInstance<T>();

        /// <summary>
        ///     Retrieve an Instance based on the key.
        ///     ex. `injectionBinder.Get(typeof(ISomeInterface));`
        /// </summary>
        object GetInstance(Type key);
    }
}
