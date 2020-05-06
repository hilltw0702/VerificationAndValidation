using System;
using System.Collections.Generic;
using GradeCalculator.Lib.Grading;
using NUnit.Framework;

namespace GradeCalculator.Lib.UnitTesting
{
    [TestFixture]
    public class ATraditionalGradeScale
    {
        [Category("TraditionalGradeScale")]
        [Test(Description = "Initialize()")]
        public void ShouldInitializeItselfWithATraditionalGradingScale()
        {
            var expectedGradeScale = new Dictionary<char, Tuple<int, int>>(5)
            {
                {'A', new Tuple<int, int>(90, 100) },
                {'B', new Tuple<int, int>(80, 89) },
                {'C', new Tuple<int, int>(70, 79) },
                {'D', new Tuple<int, int>(60, 69) },
                {'F', new Tuple<int, int>(0, 59) }
            };

            var sut = new TraditionalGradeScale();

            Assert.That(sut.Scale, Is.EqualTo(expectedGradeScale));
        }

    }
}
