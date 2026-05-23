using Itmo.ObjectOrientedProgramming.ValueObjects;

namespace Itmo.ObjectOrientedProgramming.Entities;

public class EducationalProgram
{
    public Guid Id { get; }

    public ElementName Name { get; }

    public Dictionary<int, Subject> Subjects { get; }

    public User Author { get; private init; }

    public EducationalProgram(ElementName name, Dictionary<int, Subject> subjects, User author)
    {
        Id = Guid.NewGuid();
        Name = name;
        Subjects = subjects;
        Author = author;
    }
}