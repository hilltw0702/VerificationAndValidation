using GradeCalculator.Lib.File;
using NUnit.Framework;

namespace GradeCalculator.Lib.UnitTesting
{
    [TestFixture]
    public class ATextFileWriter
    {
        [Category("TextFileWriter")]
        [TestCase(',', Description = "TextFileWriter(string filePath)")]
        public void ShouldBeConstructedWithADefaultDelimiterAndTextFileWriterAtGivenFilePath(char expected)
        {
            var file = System.IO.File.Create("testFile.txt");
            var filePath = "";
            using (file)
                filePath = file.Name;

            var sut = new TextFileWriter(filePath);

            Assert.That(sut.Delimiter, Is.EqualTo(expected));
            Assert.That(sut.FilePath, Is.EqualTo(filePath));

            sut.Dispose();
            System.IO.File.Delete(filePath);
        }

        [Category("TextFileWriter")]
        [TestCase('|', '|', Description = "TextFileWriter(string filePath, char delimiter)")]
        public void ShouldBeConstructedWithAGivenDelimiterAndTextFileWriterAtGivenPath(char delimiter, char expected)
        {
            var file = System.IO.File.Create("testFile.txt");
            var filePath = "";
            using (file)
                filePath = file.Name;

            var sut = new TextFileWriter(filePath, delimiter);

            Assert.That(sut.Delimiter, Is.EqualTo(expected));
            Assert.That(sut.FilePath, Is.EqualTo(filePath));

            sut.Dispose();
            System.IO.File.Delete(filePath);
        }
    }
}
