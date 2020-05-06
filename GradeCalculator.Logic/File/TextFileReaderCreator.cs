namespace GradeCalculator.Lib.File
{
    /// <summary>
    /// Factory for creating types of <see cref="TextFileReader"/>.
    /// </summary>
    /// <seealso cref="FileReaderCreator" />
    public class TextFileReaderCreator : FileReaderCreator
    {
        /// <summary>
        /// Factory method that creates a type of <see cref="TextFileReader" />.
        /// </summary>
        /// <param name="filePath">The path to the file being read.</param>
        /// <returns>
        /// Type of <see cref="TextFileReader" />.
        /// </returns>
        public override object Create(string filePath)
        {
            return new TextFileReader(filePath);
        }
    }
}
