namespace School.Domain.Repositories.Base
{
    public interface IRepository<T> : IDisposable where T : IAggregationInterface
    {
    }
}
