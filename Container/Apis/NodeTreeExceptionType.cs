namespace IocContainer.Binder;

public enum ContainerExceptionType
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
