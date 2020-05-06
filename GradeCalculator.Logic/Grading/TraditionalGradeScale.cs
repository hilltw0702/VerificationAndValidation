using System;

namespace GradeCalculator.Lib.Grading
{
    /// <summary>
    /// Represents a traditional type of grading scale.
    /// </summary>
    /// <seealso cref="GradeScale" />
    public sealed class TraditionalGradeScale : GradeScale
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TraditionalGradeScale"/> class.
        /// </summary>
        public TraditionalGradeScale() : base()
        {

        }

        /// <summary>
        /// Initializes this instance's <see cref="Scale" /> property with a
        /// traditional type of grading scale.
        /// </summary>
        public override void Initialize()
        {
            Scale.Add('A', new Tuple<int, int>(90, 100));
            Scale.Add('B', new Tuple<int, int>(80, 89));
            Scale.Add('C', new Tuple<int, int>(70, 79));
            Scale.Add('D', new Tuple<int, int>(60, 69));
            Scale.Add('F', new Tuple<int, int>(0, 59));
        }
    }
}
