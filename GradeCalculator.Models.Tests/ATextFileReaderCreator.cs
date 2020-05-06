using GradeCalculator.Lib.File;
using NUnit.Framework;
using System;

namespace GradeCalculator.Lib.UnitTesting
{
    [TestFixture]
    public class ATextFileReaderCreator
    {
        [Category("TextFileReaderCreator")]
        [TestCase("testFile.txt", typeof(TextFileReader), Description = "Create()")]
        public void ShouldCreateANewTextFileReader(string fileName, Type expected)
        {
            var file = System.IO.File.Create(fileName);
            var filePath = "";
            using (file)
                filePath = file.Name;

            var sut = new TextFileReaderCreator();
            var textFileReader = (TextFileReader)sut.Create(filePath);

            Assert.That(textFileReader.GetType(), Is.EqualTo(expected));

            textFileReader.Dispose();
            System.IO.File.Delete(filePath);
        }
    }
}