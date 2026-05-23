using Itmo.ObjectOrientedProgramming.Results;
using Itmo.ObjectOrientedProgramming.ValueObjects;

namespace Itmo.ObjectOrientedProgramming.Entities;

public class ExamSubject : Subject
{
    public ExamSubject(
        ElementName name,
        IReadOnlyCollection<Laboratory> laboratories,
        IReadOnlyCollection<LectureMaterials> lectureMaterials,
        Grades points,
        User author) : base(name, laboratories, lectureMaterials, points, author) { }

    public override SubjectResults SumGrades()
    {
        int sum = 0;
        foreach (Laboratory lab in LabsList)
        {
            sum += lab.Points.Value;
        }

        return sum + PointsNeeded.Value is < 100 or > 100
            ? new SubjectResults.SubjectGradesSumIncorrect(sum)
            : new SubjectResults.SubjectGradesSumCorrect(sum);
    }
}