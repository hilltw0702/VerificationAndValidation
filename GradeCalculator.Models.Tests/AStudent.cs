using GradeCalculator.Lib.Entity;
using NUnit.Framework;
using System.Collections.Generic;

namespace GradeCalculator.Lib.UnitTesting
{
    [TestFixture]
    public class AStudent
    {
        [Category("Student")]
        [Test(Description = "Equals(object obj)")]
        public void ShouldDetermineIfTwoStudentsAreEqual()
        {
            var equal = new Student
            {
                FirstName = "Tomas",
                LastName = "Hill",
                QuizGrades = new List<int>
                {
                    100, 100, 100, 100, 100, 100, 100, 100, 100, 100
                }
            };

            var notEqual = new Student
            {
                FirstName = "Tomas",
                LastName = "Hill",
                QuizGrades = new List<int>
                {
                    100, 100, 80, 100, 75, 100, 80, 100, 63, 100
                }
            };

            var sut = new Student
            {
                FirstName = "Tomas",
                LastName = "Hill",
                QuizGrades = new List<int>
                {
                    100, 100, 100, 100, 100, 100, 100, 100, 100, 100
                }
            };


            Assert.That(sut.Equals(equal), Is.True);
            Assert.That(sut.Equals(notEqual), Is.False);
        }
    }
}
