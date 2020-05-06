namespace GradeCalculator.Lib.File
{
    /// <summary>
    /// Factory for creating types of <see cref="FileWriter"/>.
    /// </summary>
    public abstract class FileWriterCreator
    {
        /// <summary>
        /// Factory method that creates a type of <see cref="FileWriter"/>.
        /// </summary>
        /// <param name="filePath">The path to the file being written.</param>
        /// <returns>Type of <see cref="FileWriter"/>.</returns>
        public abstract object Create(string filePath);
    }
}
