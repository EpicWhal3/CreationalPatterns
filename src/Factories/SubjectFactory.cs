using Itmo.ObjectOrientedProgramming.Entities;
using Itmo.ObjectOrientedProgramming.ValueObjects;

namespace Itmo.ObjectOrientedProgramming.Factories;

public abstract class SubjectFactory
{
    public abstract Subject CreateSubject(
        ElementName name,
        IReadOnlyCollection<Laboratory> laboratories,
        IReadOnlyCollection<LectureMaterials> lectureMaterials,
        Grades points,
        User author);
}