using System;

namespace GradeCalculator.Lib.File
{
    /// <summary>
    /// Provides a mechanism for reading from a file.
    /// </summary>
    /// <seealso cref="IEndOfFile" />
    /// <seealso cref="IReadRecord" />
    /// <seealso cref="IDisposable" />
    public interface IFileReader : IEndOfFile, IReadRecord, IDisposable
    {

    }
}
