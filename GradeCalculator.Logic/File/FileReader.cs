using GradeCalculator.Lib.Entity;
using System.Collections.Generic;

namespace GradeCalculator.Lib.File
{
    /// <summary>
    /// Represents an abstraction on the type of file reader that can be 
    /// used to read individual student records to a file.
    /// </summary>
    /// <seealso cref="IFileReader" />
    public abstract class FileReader : IFileReader
    {
        /// <summary>
        /// The path to the file being read.
        /// </summary>
        public string FilePath { get; set; }


        /// <summary>
        /// Determines if the end of the file has been reached.
        /// </summary>
        /// <returns>True if the end of the file has been reached, false otherwise.</returns>
        /// <seealso cref="IEndOfFile"/>
        public abstract bool EndOfFile();

        /// <summary>
        /// Reads an individual line representing a <see cref="Entity.Student" />
        /// record from a file.
        /// </summary>
        /// <returns>The line recently read from the file broken up into
        /// its individual <see cref="Student"/> attributes.</returns>
        /// <seealso cref="IReadRecord"/>
        public abstract IDictionary<string, string> ReadRecord();

        /// <summary>
        /// Releases unmanaged and - optionally - managed resources.
        /// </summary>
        /// <seealso cref="System.IDisposable"/>
        public abstract void Dispose();
    }
}
