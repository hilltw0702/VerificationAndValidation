using System.Collections.Generic;
using System.Linq;

namespace GradeCalculator.Lib.Entity
{
    /// <summary>
    /// Represents a student with a first name, last name, and collection of
    /// quiz grades.
    /// </summary>
    public class Student
    {
        /// <summary>
        /// The first name of the student.
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// The last name of the student.
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// Ac collection representing the student's quiz grades.
        /// </summary>
        public ICollection<int> QuizGrades { get; set; }


        /// <summary>
        /// Initializes a new instance of the <see cref="Student"/> class.
        /// </summary>
        public Student()
        {
            QuizGrades = new List<int>();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Student"/> class.
        /// </summary>
        /// <param name="firstName">The student's first name.</param>
        /// <param name="lastName">The student's last name.</param>
        /// <param name="quizGrades">A collection representing the student's quiz grades.</param>
        public Student(string firstName, string lastName, ICollection<int> quizGrades)
        {
            FirstName = firstName;
            LastName = lastName;
            QuizGrades = quizGrades;
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
                Student s = (Student)obj;

                if (FirstName != s.FirstName || LastName != s.LastName)
                    return false;

                return QuizGrades.SequenceEqual(s.QuizGrades);
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
