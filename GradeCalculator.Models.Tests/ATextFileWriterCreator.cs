using GradeCalculator.Lib.File;
using NUnit.Framework;
using System;

namespace GradeCalculator.Lib.UnitTesting
{
    [TestFixture]
    public class ATextFileWriterCreator
    {
        [Category("TextFileWriterCreator")]
        [TestCase("testFile.txt", typeof(TextFileWriter), Description = "Create()")]
        public void ShouldCreateANewTextFileWriter(string fileName, Type expected)
        {
            var file = System.IO.File.Create(fileName);
            var filePath = "";
            using (file)
                filePath = file.Name;

            var sut = new TextFileWriterCreator();
            var textFileWriter = (TextFileWriter)sut.Create(filePath);

            Assert.That(textFileWriter.GetType(), Is.EqualTo(expected));

            textFileWriter.Dispose();
            System.IO.File.Delete(filePath);
        }
    }
}