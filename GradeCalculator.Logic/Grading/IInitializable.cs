namespace GradeCalculator.Lib.Grading
{
    /// <summary>
    /// Provides a mechanism for initializing a type of <see cref="GradeScale"/>.
    /// </summary>
    public interface IInitializable
    {
        /// <summary>
        /// Initializes the instance's <see cref="GradeScale.Scale"/> property.
        /// </summary>
        void Initialize();
    }
}
