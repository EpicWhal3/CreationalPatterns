using Itmo.ObjectOrientedProgramming.Contracts;
using Itmo.ObjectOrientedProgramming.Entities;

namespace Itmo.ObjectOrientedProgramming.Repository;

public class SubjectsRepositories : IRepository<Subject>
{
    private readonly ICollection<Subject> _repo = [];

    public void Add(Subject entity)
    {
        _repo.Add(entity);
    }

    public Subject GetById(Guid id)
    {
        return _repo.FirstOrDefault(x => x.Id == id) ??
               throw new ArgumentException("User not found");
    }
}