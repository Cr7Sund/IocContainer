namespace IocContainer.Binder
{
    public interface IContext : IDisposable
    {
        IInjectionBinder InjectionBinder { get;  }
        /// Register a new context to this one
        void AddContext(IContext context);

        /// Remove a context from this one
        void RemoveContext(IContext context);

        void RemoveComponents();
    }
}
