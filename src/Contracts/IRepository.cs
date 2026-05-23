namespace Itmo.ObjectOrientedProgramming.Contracts;

public interface IRepository<T>
{
    public void Add(T entity);

    public T GetById(Guid id);
}