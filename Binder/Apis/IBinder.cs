namespace IocContainer.Binder
{

    internal interface IBinder : IDisposable
    {
        /// <summary>
        ///     Bind a Binding Key to a class or interface generic
        /// </summary>
        IBinding Bind<T>();
        /// <summary>
        ///     Bind a Binding Key to a object
        /// </summary>
        IBinding Bind(object key);

        /// <summary>
        ///     Retrieve a binding based on the provided Type
        /// </summary>
        IBinding GetBinding<T>();
        /// <summary>
        ///  Retrieve a binding based on the provided Type and name
        /// </summary>
        /// <param name="name"></param>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        IBinding GetBinding<T>(object name);
        /// <summary>
        ///     Retrieve a binding based on the provided key
        /// </summary>
        IBinding GetBinding(object key);

        /// <summary>
        ///     Retrieve a binding based on the provided key
        /// </summary>
        IBinding GetBinding(object key, object name);

        /// <summary>
        ///     Remove a binding based on the provided Key (generic)
        /// </summary>
        void Unbind<T>();
        /// <summary>
        ///     Remove a binding based on the provided Key and its name
        /// </summary>
        void Unbind<T>(object name);
        /// <summary>
        ///     Remove a binding based on the provided Key (generic)
        /// </summary>
        void Unbind(object key);

        /// <summary> Remove the provided binding from the Binder </summary>
        void Unbind(IBinding binding);

        /// <summary>
        ///     Remove a binding based on the provided Key (generic)
        /// </summary>
        void Unbind(object key, object name);

        /// <summary> Remove a select value from the given binding </summary>
        void RemoveValue(IBinding binding, object value);

        /// <summary>
        ///     The Binder is being removed
        ///     Override this method to clean up remaining bindings
        /// </summary>
        void OnRemove();

        /// <summary>
        ///     Places individual Bindings into the bindings Dictionary as part of the resolving process
        /// </summary>
        void ResolveBinding(IBinding binding, object key, object oldName);

        /// <summary>
        /// copy bindings from binder
        /// </summary>
        /// <param name="fromBinder"></param>
        void CopyFrom(IBinder fromBinder);

        /// <summary>
        /// remove all  bindings 
        /// not unbind since the binding maybe come from other binders
        /// </summary>
        void RemoveAll();
    }

}
