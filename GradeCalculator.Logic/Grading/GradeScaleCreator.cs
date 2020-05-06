namespace GradeCalculator.Lib.Grading
{
    /// <summary>
    /// Factory for creating types of <see cref="GradeScale"/>.
    /// </summary>
    public abstract class GradeScaleCreator
    {
        /// <summary>
        /// Factory method that creates a type of <see cref="GradeScale"/>.
        /// </summary>
        /// <returns>Type of <see cref="GradeScale"/>.</returns>
        public abstract object Create();
    }
}
