namespace Cr7Sund.IocContainer
{
    internal enum ContextExceptionType
    {
        /// <summary>
        /// try to assign duplicate cross context
        /// </summary>
        DuplicateCrossContext,
        /// <summary>
        /// there should be a cross context
        /// </summary>
        EmptyCrossContext
    }
    
}