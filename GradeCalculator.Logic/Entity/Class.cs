using GradeCalculator.Lib.File;
using GradeCalculator.Lib.Grading;

namespace GradeCalculator.Lib.Entity
{
    /// <summary>
    /// Represents a class of students.
    /// </summary>
    public class Class
    {
        /// <summary>
        /// The collection of students within the class.
        /// </summary>
        /// <seealso cref="StudentList\"/>
        public StudentList Students { get; set; }

        /// <summary>
        /// The grading scale used to determine grades.
        /// </summary>
        /// <seealso cref="GradeScale"/>
        public GradeScale Scale { get; set; }

        /// <summary>
        /// The file reader to be used.
        /// </summary>
        /// <seealso cref="FileReader"/>
        public FileReader Reader { get; set; }

        /// <summary>
        /// The file writer to be used.
        /// </summary>
        /// <seealso cref="FileWriter"/>
        public FileWriter Writer { get; set; }


        /// <summary>
        /// Initializes a new instance of the <see cref="Class"/> class.
        /// </summary>
        public Class()
        {
            Students = new StudentList();
            Scale = new TraditionalGradeScale();
        }

        /// <summary>
        /// Reads a collection of <see cref="Student"/> records from a file.
        /// </summary>
        public void ReadFromFile()
        {
            Students.ReadStudentsFromFile(Reader);
        }

        /// <summary>
        /// Writes a collection of <see cref="Student"/> records to a file.
        /// </summary>
        public void WriteToFile()
        {
            Students.WriteStudentsToFile(Writer, Scale);
        }
    }
}
