namespace GradeCalculator.Lib.Grading
{
    /// <summary>
    /// Factory for creating types of <see cref="TraditionalGradeScale"/>.
    /// </summary>
    /// <seealso cref="GradeScaleCreator" />
    public sealed class TraditionalGradeScaleCreator : GradeScaleCreator
    {
        /// <summary>
        /// Factory method that creates a type of <see cref="TraditionalGradeScale" />.
        /// </summary>
        /// <returns>
        /// Type of <see cref="TraditionalGradeScale" />.
        /// </returns>
        public override object Create()
        {
            return new TraditionalGradeScale();
        }
    }
}
