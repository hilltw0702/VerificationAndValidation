namespace GradeCalculator.Lib.File
{
    /// <summary>
    /// Provides a mechanism for determining if the end of a file has been reached.
    /// </summary>
    public interface IEndOfFile
    {
        /// <summary>
        /// Determines if the end of the file has been reached.
        /// </summary>
        /// <returns>True if the end of the file has been reached, false otherwise.</returns>
        bool EndOfFile();
    }
}
