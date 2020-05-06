using System;

namespace GradeCalculator.Lib.File
{
    /// <summary>
    /// Provides a mechanism for writing to a file.
    /// </summary>
    /// <seealso cref="GradeCalculator.Lib.File.IWriteRecord" />
    /// <seealso cref="System.IDisposable" />
    public interface IFileWriter : IWriteRecord, IDisposable
    {

    }
}
