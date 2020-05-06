namespace GradeCalculator.Lib.File
{
    /// <summary>
    /// Factory for creating types of <see cref="FileReader"/>.
    /// </summary>
    public abstract class FileReaderCreator
    {
        /// <summary>
        /// Factory method that creates a type of <see cref="FileReader"/>.
        /// </summary>
        /// <param name="filePath">The path to the file being read.</param>
        /// <returns>Type of <see cref="FileReader"/>.</returns>
        public abstract object Create(string filePath);
    }
}
