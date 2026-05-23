using Itmo.ObjectOrientedProgramming.Contracts;
using Itmo.ObjectOrientedProgramming.Results;
using Itmo.ObjectOrientedProgramming.ValueObjects;

namespace Itmo.ObjectOrientedProgramming.Entities;

public class Laboratory : IPrototype<Laboratory>
{
    public Guid Id { get; }

    public Grades Points { get; }

    public Guid BasedOn { get; private set; }

    private Criteries Criteries { get; }

    private Description Description { get; set; }

    private User Author { get; }

    private ElementName Name { get; }

    public Laboratory(
        ElementName name,
        Description description,
        Criteries criteries,
        Grades points,
        User? author = null)
    {
        Id = Guid.NewGuid();
        Name = name;
        Description = description;
        Criteries = criteries;
        Points = points;

        Author = author ?? User.CreateDefaultUser();

        BasedOn = Id;
    }

    public Laboratory Clone(User author)
    {
        var result = new Laboratory(Name, Description, Criteries, Points, author)
        {
            BasedOn = BasedOn,
        };

        return result;
    }

    public LabResults Update(User requester, Description newMessage)
    {
        if (requester != Author)
        {
            return new LabResults.UnAuthorizedAccessToLab(requester);
        }

        Description = newMessage;

        return new LabResults.SuccessfulUpdateLab();
    }
}