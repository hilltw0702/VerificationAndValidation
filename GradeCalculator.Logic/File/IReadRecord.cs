using System.Collections.Generic;

namespace GradeCalculator.Lib.File
{
    /// <summary>
    /// Provides a mechanism for reading an individual record representing a 
    /// <see cref="Entity.Student"/> from a file.
    /// </summary>
    public interface IReadRecord
    {
        /// <summary>
        /// Reads an individual record representing a <see cref="Entity.Student"/>
        /// from a file.
        /// </summary>
        /// <returns>The record recently read from the file broken up into
        /// its individual <see cref="Student"/> attributes.</returns>
        IDictionary<string, string> ReadRecord();
    }
}
