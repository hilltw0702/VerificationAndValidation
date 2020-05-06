using GradeCalculator.Lib.File;
using NUnit.Framework;

namespace GradeCalculator.Lib.UnitTesting
{
    [TestFixture]
    public class ATextFileReader
    {
        [Category("TextFileReader")]
        [TestCase(',', "testFile.txt", Description = "TextFileReader(string filePath)")]
        public void ShouldBeConstructedWithADefaultDelimiterAndTextFileReaderAtGivenFilePath(char expected, string testPath)
        {
            var file = System.IO.File.Create(testPath);
            var filePath = "";
            using (file)
                filePath = file.Name;

            var sut = new TextFileReader(filePath);

            Assert.That(sut.Delimiter, Is.EqualTo(expected));
            Assert.That(sut.FilePath, Is.EqualTo(filePath));

            sut.Dispose();
            System.IO.File.Delete(filePath);
        }

        [Category("TextFileReader")]
        [TestCase('|', '|', "testFile.txt", Description = "TextFileReader(string filePath, char delimiter)")]
        public void ShouldBeConstructedWithAGivenDelimiterAndTextFileReaderAtGivenPath(char delimiter, char expected, string testPath)
        {
            var file = System.IO.File.Create(testPath);
            var filePath = "";
            using (file)
                filePath = file.Name;

            var sut = new TextFileReader(filePath, delimiter);

            Assert.That(sut.Delimiter, Is.EqualTo(expected));
            Assert.That(sut.FilePath, Is.EqualTo(filePath));

            sut.Dispose();
            System.IO.File.Delete(filePath);
        }
    }
}
