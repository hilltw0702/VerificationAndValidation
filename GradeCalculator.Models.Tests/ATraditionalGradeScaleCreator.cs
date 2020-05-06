using NUnit.Framework;
using GradeCalculator.Lib.Grading;

namespace GradeCalculator.Lib.UnitTesting
{
    [TestFixture]
    public class ATraditionalGradeScaleCreator
    {
        [Category("TraditionalGradeScaleCreator: Create()")]
        [Test(Description = "Create()")]
        public void ShouldCreateANewTraditionalGradeScale()
        {
            var sut = new TraditionalGradeScaleCreator();
            var traditionalGradeScale = sut.Create();

            Assert.That(traditionalGradeScale.GetType(), Is.EqualTo(typeof(TraditionalGradeScale)));
        }
    }
}