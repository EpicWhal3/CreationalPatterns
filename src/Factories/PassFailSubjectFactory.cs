using Itmo.ObjectOrientedProgramming.Entities;
using Itmo.ObjectOrientedProgramming.ValueObjects;

namespace Itmo.ObjectOrientedProgramming.Factories;

public class PassFailSubjectFactory : SubjectFactory
{
    public override Subject CreateSubject(
        ElementName name,
        IReadOnlyCollection<Laboratory> laboratories,
        IReadOnlyCollection<LectureMaterials> lectureMaterials,
        Grades points,
        User author)
    {
        return new PassFailSubject(name, laboratories, lectureMaterials, points, author);
    }
}