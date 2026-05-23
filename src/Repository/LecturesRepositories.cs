using Itmo.ObjectOrientedProgramming.Contracts;
using Itmo.ObjectOrientedProgramming.Entities;

namespace Itmo.ObjectOrientedProgramming.Repository;

public class LecturesRepositories : IRepository<LectureMaterials>
{
    private readonly ICollection<LectureMaterials> _repo = [];

    public void Add(LectureMaterials entity)
    {
        _repo.Add(entity);
    }

    public LectureMaterials GetById(Guid id)
    {
        return _repo.FirstOrDefault(x => x.Id == id) ??
               throw new ArgumentException("User not found");
    }
}