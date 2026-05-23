using Itmo.ObjectOrientedProgramming.Contracts;
using Itmo.ObjectOrientedProgramming.Entities;

namespace Itmo.ObjectOrientedProgramming.Repository;

public class UserRepositories : IRepository<User>
{
    private readonly ICollection<User> _repo = [];

    public void Add(User entity)
    {
        _repo.Add(entity);
    }

    public User GetById(Guid id)
    {
        return _repo.FirstOrDefault(x => x.Id == id) ??
               throw new ArgumentException("User not found");
    }
}