namespace Itmo.ObjectOrientedProgramming.Contracts;

public interface IRepository<T>
{
    void Add(T entity);

    T GetById(Guid id);
}