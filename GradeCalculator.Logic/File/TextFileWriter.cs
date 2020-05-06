using System;
using System.Collections.Generic;
using System.IO;

namespace GradeCalculator.Lib.File
{
    /// <summary>
    /// Represents a text file writer.
    /// </summary>
    /// <seealso cref="FileWriter" />
    public sealed class TextFileWriter : FileWriter
    {
        /// <summary>
        /// The delimiter that the text file uses.
        /// </summary>
        public char Delimiter { get; private set; }

        /// <summary>
        /// The underlying <see cref="StreamWriter"/> object used to read the text file.
        /// </summary>
        private StreamWriter Writer { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="TextFileWriter"/> class.
        /// </summary>
        /// <param name="filePath">The file path to the text file to write.</param>
        /// <param name="delimiter">The delimiter used in the text file to write.</param>
        public TextFileWriter(string filePath, char delimiter = ',')
        {
            Delimiter = delimiter;
            Writer = new StreamWriter(filePath);
            FilePath = ((FileStream)Writer.BaseStream).Name;
        }

        /// <summary>
        /// Writes an individual record representing a <see cref="Student" /> to a file.
        /// </summary>
        /// <param name="record">The record.</param>
        /// <seealso cref="IWriteRecord" />
        public override void WriteRecord(List<string> record)
        {
            Writer.WriteLine(string.Join(Delimiter, record));
        }

        /// <summary>
        /// Releases unmanaged and - optionally - managed resources.
        /// </summary>
        /// <seealso cref="IDisposable" />
        public override void Dispose()
        {
            Writer.Dispose();
        }
    }
}
