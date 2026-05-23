using Itmo.ObjectOrientedProgramming.Contracts;
using Itmo.ObjectOrientedProgramming.Entities;
using Itmo.ObjectOrientedProgramming.ValueObjects;

namespace Itmo.ObjectOrientedProgramming.Factories;

public class ConrcreteEducationalProgramFactory : IEducationalProgramFactory
{
    public override EducationalProgram CreateEducationalProgram(
        ElementName name,
        Dictionary<int, Subject> subjects,
        User author)
    {
        return new EducationalProgram(name, subjects, author);
    }
}