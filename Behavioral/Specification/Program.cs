using System;

namespace DesignPatterns.Behavioral.Specification
{
    class Program
    {
        static void Main(string[] args)
        {
            // Specification design pattern allows recombinable business logic in a Boolean fashion.
            var subject1 = new SubjectSpecification("subject1");
            var subject2 = new SubjectSpecification("subject2");
            var subject3 = new SubjectSpecification("subject3");

            var condition = subject1.Or(subject2.And(subject3.Not()));
            var isSatisfied = condition.IsSatisfiedBy(subject3);

            Console.WriteLine(isSatisfied.ToString());
        }
    }
}
