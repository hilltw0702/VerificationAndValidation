using System;
using System.Collections.Generic;

namespace GradeCalculator.Lib.File
{
    /// <summary>
    /// Represents an abstraction on the type of file writer that can be 
    /// used to writer individual student records to a file.
    /// </summary>
    /// <seealso cref="IFileWriter" />
    public abstract class FileWriter : IFileWriter
    {
        /// <summary>
        /// The path to the file being written.
        /// </summary>
        public string FilePath { get; set; }


        /// <summary>
        /// Writes an individual record representing a <see cref="Student"/> to a file.
        /// </summary>
        /// <param name="record">The record.</param>
        /// <seealso cref="IWriteRecord"/>
        public abstract void WriteRecord(List<string> record);

        /// <summary>
        /// Releases unmanaged and - optionally - managed resources.
        /// </summary>
        /// <seealso cref="IDisposable"/>
        public abstract void Dispose();
    }
}
