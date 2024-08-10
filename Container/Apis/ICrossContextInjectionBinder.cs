namespace IocContainer.Binder
{

    internal interface ICrossContextInjectionBinder : IInjectionBinder
    {
        /// <summary>
        ///     Cross-context Injection Binder is shared across all child contexts
        /// </summary>
        IInjectionBinder CrossContextBinder { get; set; }
    }
    
}