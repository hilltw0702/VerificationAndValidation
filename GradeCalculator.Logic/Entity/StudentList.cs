using GradeCalculator.Lib.File;
using GradeCalculator.Lib.Grading;
using System;
using System.Collections.Generic;
using System.Linq;

namespace GradeCalculator.Lib.Entity
{
    /// <summary>
    /// A collection of <see cref="Student"/> objects.
    /// </summary>
    public class StudentList
    {
        /// <summary>
        /// The underlying collection of <see cref="Student"/> objects.
        /// </summary>
        public ICollection<Student> Students { get; set; }


        /// <summary>
        /// Initializes a new instance of the <see cref="StudentList"/> class.
        /// </summary>
        public StudentList()
        {
            Students = new List<Student>();
        }

        /// <summary>
        /// Gets the number of students in the collection.
        /// </summary>
        /// <returns>The number of students in the collectionl</returns>
        public int NumberOfStudents()
        {
            return Students.Count;
        }

        /// <summary>
        /// Reads a collection of <see cref="Student"/> objects from a file.
        /// </summary>
        /// <param name="reader">The type of <see cref="FileReader"/> to use.</param>
        /// <seealso cref="FileReader"/>
        public void ReadStudentsFromFile(FileReader reader)
        {
            var students = new List<Student>();

            using (reader)
            {
                while (!reader.EndOfFile())
                {
                    var nextStudent = reader.ReadRecord();

                    var student = new Student()
                    {
                        FirstName = nextStudent["First Name"],
                        LastName = nextStudent["Last Name"]
                    };

                    for (int i = 1; i <= 10; i++)
                    {
                        try
                        {
                            student.QuizGrades.Add(int.Parse(nextStudent[$"Quiz {i}"]));
                        }
                        catch
                        {
                            break;
                        }
                    }

                    students.Add(student);
                }
            }

            Students = students;
        }

        /// <summary>
        /// Writes a collection of <see cref="Student"/> objects to a file.
        /// </summary>
        /// <param name="writer">The type of <see cref="FileWriter"/> to use.</param>
        /// <param name="scale">The type of <see cref="GradeScale"/> to use for grade conversions.</param>
        /// <seealso cref="FileWriter"/>
        public void WriteStudentsToFile(FileWriter writer, GradeScale scale)
        {
            using (writer)
            {
                foreach (var student in Students)
                {
                    var studentRecord = new List<string>();

                    studentRecord.Add(student.LastName);
                    studentRecord.Add(student.FirstName);

                    int quizGradeTotal = 0;

                    foreach (var grade in student.QuizGrades)
                    {
                        quizGradeTotal += grade;
                        studentRecord.Add(grade.ToString());
                    }

                    double numericalQuizGrade = quizGradeTotal / 10.0;
                    studentRecord.Add(Math.Round(numericalQuizGrade, 1).ToString());
                    studentRecord.Add(scale.GetLetterGrade(Math.Round(numericalQuizGrade)).ToString());

                    writer.WriteRecord(studentRecord);
                }
            }
        }

        /// <summary>
        /// Determines whether the specified <see cref="System.Object" />, is equal to this instance.
        /// </summary>
        /// <param name="obj">The <see cref="System.Object" /> to compare with this instance.</param>
        /// <returns>
        ///   <c>true</c> if the specified <see cref="System.Object" /> is equal to this instance; otherwise, <c>false</c>.
        /// </returns>
        public override bool Equals(object obj)
        {
            if (obj == null || !GetType().Equals(obj.GetType()))
                return false;
            else
            {
                StudentList s = (StudentList)obj;

                return Students.SequenceEqual(s.Students);
            }
        }

        /// <summary>
        /// Returns a hash code for this instance.
        /// </summary>
        /// <returns>
        /// A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. 
        /// </returns>
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
