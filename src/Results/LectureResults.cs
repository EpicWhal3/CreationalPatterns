using Itmo.ObjectOrientedProgramming.Entities;

namespace Itmo.ObjectOrientedProgramming.Results;

public abstract record LectureResults
{
    private LectureResults() { }

    public sealed record SuccessfulUpdateLecture : LectureResults;

    public sealed record UnAuthorizedAccessLecture : LectureResults
    {
        public User Requester { get; private set; }

        public UnAuthorizedAccessLecture(User requester)
        {
            Requester = requester;
        }
    }

    public sealed record LectureOriginNotEqual : LectureResults;

    public sealed record LectureOriginEqual : LectureResults;
}