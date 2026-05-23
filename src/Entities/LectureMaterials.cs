using Itmo.ObjectOrientedProgramming.Contracts;
using Itmo.ObjectOrientedProgramming.Results;
using Itmo.ObjectOrientedProgramming.ValueObjects;

namespace Itmo.ObjectOrientedProgramming.Entities;

public class LectureMaterials : IPrototype<LectureMaterials>
{
    public Guid Id { get; }

    public Guid BasedOn { get; private init; }

    private ElementName Name { get; }

    private Description Summary { get; }

    private Description Content { get; set; }

    private User Author { get; }

    public LectureMaterials(ElementName title, Description summary, Description content, User author)
    {
        Id = Guid.NewGuid();
        Name = title;
        Summary = summary;
        Content = content;
        Author = author;
        BasedOn = Id;
    }

    public LectureMaterials Clone(User author)
    {
        var result = new LectureMaterials(Name, Summary, Content, author)
        {
            BasedOn = BasedOn,
        };

        return result;
    }

    public LectureResults Update(User requester, Description newMessage)
    {
        if (requester != Author)
        {
            return new LectureResults.UnAuthorizedAccessLecture(requester);
        }

        Content = newMessage;

        return new LectureResults.SuccessfulUpdateLecture();
    }
}