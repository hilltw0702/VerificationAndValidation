using GradeCalculator.Lib.Entity;
using GradeCalculator.Lib.File;
using GradeCalculator.Lib.Grading;
using Moq;
using NUnit.Framework;
using System.Collections.Generic;

namespace GradeCalculator.Lib.UnitTesting
{
    [TestFixture]
    public class AStudentList
    {
        [Category("StudentList")]
        [TestCase(5, 5, Description = "ReadStudentsFromFile(FileReader reader)")]
        public void ShouldReadStudentsFromAFile(int numStudents, int expectedNumStudents)
        {
            var expected = new List<Student>(numStudents)
            {
                new Student("Tomas", "Hill", new List<int>
                {
                    76, 44, 72, 8, 88, 75, 10, 9, 12, 60
                }),
                new Student("Cait", "Emond", new List<int>
                {
                    100, 100, 100, 100, 100, 100, 100, 100, 100, 100
                }),
                new Student("Will", "Rochelle", new List<int>
                {
                    100, 80, 80, 80, 80, 80, 80, 80, 80, 80
                }),
                new Student("Austin", "Helton", new List<int>
                {
                    100, 50, 75, 89, 90, 95, 98, 99, 100
                }),
                new Student("Dave", "Schmidt", new List<int>
                {

                })
            };

            var mock = new Mock<FileReader>();

            mock.SetupSequence(x => x.EndOfFile())
                .Returns(false)
                .Returns(false)
                .Returns(false)
                .Returns(false)
                .Returns(false)
                .Returns(true);

            mock.SetupSequence(x => x.ReadRecord())
                .Returns(new Dictionary<string, string>
                {
                    { "First Name", "Tomas" },
                    { "Last Name", "Hill" },
                    { "Quiz 1", "76" },
                    { "Quiz 2", "44" },
                    { "Quiz 3", "72" },
                    { "Quiz 4", "8" },
                    { "Quiz 5", "88" },
                    { "Quiz 6", "75" },
                    { "Quiz 7", "10" },
                    { "Quiz 8", "9" },
                    { "Quiz 9", "12" },
                    { "Quiz 10", "60" }
                })
                .Returns(new Dictionary<string, string>
                {
                    { "First Name", "Cait" },
                    { "Last Name", "Emond" },
                    { "Quiz 1", "100" },
                    { "Quiz 2", "100" },
                    { "Quiz 3", "100" },
                    { "Quiz 4", "100" },
                    { "Quiz 5", "100" },
                    { "Quiz 6", "100" },
                    { "Quiz 7", "100" },
                    { "Quiz 8", "100" },
                    { "Quiz 9", "100" },
                    { "Quiz 10", "100" }
                })
                .Returns(new Dictionary<string, string>
                {
                    { "First Name", "Will" },
                    { "Last Name", "Rochelle" },
                    { "Quiz 1", "100" },
                    { "Quiz 2", "80" },
                    { "Quiz 3", "80" },
                    { "Quiz 4", "80" },
                    { "Quiz 5", "80" },
                    { "Quiz 6", "80" },
                    { "Quiz 7", "80" },
                    { "Quiz 8", "80" },
                    { "Quiz 9", "80" },
                    { "Quiz 10", "80" }
                })
                .Returns(new Dictionary<string, string>
                {
                    { "First Name", "Austin" },
                    { "Last Name", "Helton" },
                    { "Quiz 1", "100" },
                    { "Quiz 2", "50" },
                    { "Quiz 3", "75" },
                    { "Quiz 4", "89" },
                    { "Quiz 5", "90" },
                    { "Quiz 6", "95" },
                    { "Quiz 7", "98" },
                    { "Quiz 8", "99" },
                    { "Quiz 9", "100" }
                })
                .Returns(new Dictionary<string, string>
                {
                    { "First Name", "Dave" },
                    { "Last Name", "Schmidt" }
                });

            var sut = new StudentList();
            sut.ReadStudentsFromFile(mock.Object);

            Assert.That(sut.NumberOfStudents(), Is.EqualTo(expectedNumStudents));
            Assert.That(sut.Students, Is.EqualTo(expected));
        }

        [Category("StudentList")]
        [TestCase(5, Description = "WriteStudentsToFile(FileWriter writer, GradeScale scale)")]
        public void ShouldWriteStudentsToAFile(int expectedNumStudents)
        {
            var studentsToWrite = new List<Student>()
            {
                new Student("Tomas", "Hill", new List<int>
                {
                    76, 44, 72, 8, 88, 75, 10, 9, 12, 60
                }),
                new Student("Cait", "Emond", new List<int>
                {
                    100, 100, 100, 100, 100, 100, 100, 100, 100, 100
                }),
                new Student("Will", "Rochelle", new List<int>
                {
                    100, 80, 80, 80, 80, 80, 80, 80, 80, 80
                }),
                new Student("Austin", "Helton", new List<int>
                {
                    100, 50, 75, 89, 90, 95, 98, 99, 100
                }),
                new Student("Dave", "Schmidt", new List<int>
                {

                })
            };

            var mockReader = new Mock<FileReader>();

            mockReader.SetupSequence(x => x.EndOfFile())
                .Returns(false)
                .Returns(false)
                .Returns(false)
                .Returns(false)
                .Returns(false)
                .Returns(true);

            mockReader.SetupSequence(x => x.ReadRecord())
                .Returns(new Dictionary<string, string>
                {
                    { "First Name", "Tomas" },
                    { "Last Name", "Hill" },
                    { "Quiz 1", "76" },
                    { "Quiz 2", "44" },
                    { "Quiz 3", "72" },
                    { "Quiz 4", "8" },
                    { "Quiz 5", "88" },
                    { "Quiz 6", "75" },
                    { "Quiz 7", "10" },
                    { "Quiz 8", "9" },
                    { "Quiz 9", "12" },
                    { "Quiz 10", "60" }
                })
                .Returns(new Dictionary<string, string>
                {
                    { "First Name", "Cait" },
                    { "Last Name", "Emond" },
                    { "Quiz 1", "100" },
                    { "Quiz 2", "100" },
                    { "Quiz 3", "100" },
                    { "Quiz 4", "100" },
                    { "Quiz 5", "100" },
                    { "Quiz 6", "100" },
                    { "Quiz 7", "100" },
                    { "Quiz 8", "100" },
                    { "Quiz 9", "100" },
                    { "Quiz 10", "100" }
                })
                .Returns(new Dictionary<string, string>
                {
                    { "First Name", "Will" },
                    { "Last Name", "Rochelle" },
                    { "Quiz 1", "100" },
                    { "Quiz 2", "80" },
                    { "Quiz 3", "80" },
                    { "Quiz 4", "80" },
                    { "Quiz 5", "80" },
                    { "Quiz 6", "80" },
                    { "Quiz 7", "80" },
                    { "Quiz 8", "80" },
                    { "Quiz 9", "80" },
                    { "Quiz 10", "80" }
                })
                .Returns(new Dictionary<string, string>
                {
                    { "First Name", "Austin" },
                    { "Last Name", "Helton" },
                    { "Quiz 1", "100" },
                    { "Quiz 2", "50" },
                    { "Quiz 3", "75" },
                    { "Quiz 4", "89" },
                    { "Quiz 5", "90" },
                    { "Quiz 6", "95" },
                    { "Quiz 7", "98" },
                    { "Quiz 8", "99" },
                    { "Quiz 9", "100" }
                })
                .Returns(new Dictionary<string, string>
                {
                    { "First Name", "Dave" },
                    { "Last Name", "Schmidt" }
                });

            var mockWriter = new Mock<FileWriter>();
            var mockScale = new Mock<GradeScale>();

            var sut = new StudentList();
            sut.WriteStudentsToFile(mockWriter.Object, mockScale.Object);
            sut.ReadStudentsFromFile(mockReader.Object);

            Assert.That(sut.NumberOfStudents(), Is.EqualTo(expectedNumStudents));
            Assert.That(sut.Students, Is.EqualTo(studentsToWrite));
        }
    }
}
