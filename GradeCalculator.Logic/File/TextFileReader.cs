using GradeCalculator.Lib.Entity;
using System.Collections.Generic;
using System.IO;

namespace GradeCalculator.Lib.File
{
    /// <summary>
    /// Represents a text file reader.
    /// </summary>
    /// <seealso cref="FileReader" />
    public class TextFileReader : FileReader
    {
        /// <summary>
        /// The delimiter that the text file uses.
        /// </summary>
        public char Delimiter { get; private set; }

        /// <summary>
        /// The underlying <see cref="StreamReader"/> object used to read the text file.
        /// </summary>
        private StreamReader Reader { get; set; }


        /// <summary>
        /// Initializes a new instance of the <see cref="TextFileReader"/> class.
        /// </summary>
        /// <param name="filePath">The file path to the text file to read.</param>
        /// <param name="delimiter">The delimiter used in the text file to read.</param>
        public TextFileReader(string filePath, char delimiter = ',')
        {
            Delimiter = delimiter;
            Reader = new StreamReader(filePath);
            FilePath = ((FileStream)Reader.BaseStream).Name;
        }

        /// <summary>
        /// Determines if the end of the file has been reached.
        /// </summary>
        /// <returns>
        /// True if the end of the file has been reached, false otherwise.
        /// </returns>
        /// <seealso cref="IEndOfFile" />
        public override bool EndOfFile()
        {
            return Reader.EndOfStream;
        }

        /// <summary>
        /// Reads an individual line representing a <see cref="Entity.Student" />
        /// record from a file.
        /// </summary>
        /// <returns>The line recently read from the file broken up into
        /// its individual <see cref="Student"/> attributes.</returns>
        /// <seealso cref="IReadRecord"/>
        public override IDictionary<string, string> ReadRecord()
        {
            var student = new Dictionary<string, string>();

            string[] studentString = Reader.ReadLine().Split(Delimiter);
            student.Add("Last Name", studentString[0]);
            student.Add("First Name", studentString[1]);

            for (int i = 1; i < studentString.Length - 1; i++)
                student.Add($"Quiz {i}", studentString[i+1]);

            return student;
        }

        /// <summary>
        /// Releases unmanaged and - optionally - managed resources.
        /// </summary>
        /// <seealso cref="System.IDisposable" />
        public override void Dispose()
        {
            Reader.Dispose();
        }
    }
}
