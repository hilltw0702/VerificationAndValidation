namespace GradeCalculator.Lib.File
{
    /// <summary>
    /// Factory for creating types of <see cref="TextFileWriter"/>.
    /// </summary>
    /// <seealso cref="TextFileWriterCreator" />
    public sealed class TextFileWriterCreator : FileWriterCreator
    {
        /// <summary>
        /// Factory method that creates a type of <see cref="TextFileWriter" />.
        /// </summary>
        /// <param name="filePath">The path to the file being written.</param>
        /// <returns>
        /// Type of <see cref="TextFileWriter" />.
        /// </returns>
        public override object Create(string filePath)
        {
            return new TextFileWriter(filePath);
        }
    }
}
