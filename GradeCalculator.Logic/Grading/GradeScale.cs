using System;
using System.Collections.Generic;

namespace GradeCalculator.Lib.Grading
{
    /// <summary>
    /// Represents an abstraction on the type of grading scale that
    /// can be used in a classroom setting.
    /// </summary>
    /// <seealso cref="IInitializable" />
    public abstract class GradeScale : IInitializable
    {
        /// <summary>
        /// IDictionary in which the key represents the letter grade and the
        /// value tuple reprsents the low and high numerical grades of the 
        /// corresponding letter in (low, high) form.  For example, 
        /// Scale['A'] == (90, 100).
        /// </summary>
        public IDictionary<char, Tuple<int, int>> Scale { get; private set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="GradeScale"/> class.
        /// </summary>
        public GradeScale()
        {
            Scale = new Dictionary<char, Tuple<int, int>>();
            Initialize();
        }

        /// <summary>
        /// Initializes this instance's <see cref="Scale"/> property with a 
        /// type of grading scale.
        /// </summary>
        public abstract void Initialize();

        /// <summary>
        /// Retrieves the letter grade conversion of a given numerical grade.
        /// </summary>
        /// <param name="numericalGrade">The numerical grade to convert.</param>
        /// <returns>The letter grade representation of the given numberical grade.</returns>
        public char GetLetterGrade(double numericalGrade)
        {
            char letterGrade = 'F';

            foreach(var grade in Scale)
            {
                if (numericalGrade >= grade.Value.Item1 &&
                    numericalGrade <= grade.Value.Item2)
                {
                    letterGrade = grade.Key;
                    break;
                }
            }

            return letterGrade;
        }
    }
}
