using Itmo.ObjectOrientedProgramming.Entities;

namespace Itmo.ObjectOrientedProgramming.Contracts;

public interface IPrototype<T> where T : IPrototype<T>
{
    T Clone(User author);
}