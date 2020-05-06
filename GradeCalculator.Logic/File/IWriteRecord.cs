using System.Collections.Generic;

namespace GradeCalculator.Lib.File
{
    /// <summary>
    /// Provides a mechanism for writing an individual record representing a 
    /// <see cref="Entity.Student"/> to a file.
    /// </summary>
    public interface IWriteRecord
    {
        /// <summary>
        /// Writes an individual record representing a <see cref="Student"/> to a file.
        /// </summary>
        /// <param name="record">The record to write.</param>
        void WriteRecord(List<string> record);
    }
}
