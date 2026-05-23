using Itmo.ObjectOrientedProgramming.Entities;
using Itmo.ObjectOrientedProgramming.ValueObjects;

namespace Itmo.ObjectOrientedProgramming.Contracts;

public abstract class IEducationalProgramFactory
{
    public abstract EducationalProgram CreateEducationalProgram(
        ElementName name,
        Dictionary<int, Subject> subjects,
        User author);
}