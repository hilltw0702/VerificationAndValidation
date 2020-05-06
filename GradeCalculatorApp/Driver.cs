using GradeCalculator.Lib.Entity;
using GradeCalculator.Lib.File;
using System;
using System.Collections.Generic;

namespace GradeCalculatorApp
{
    internal class Driver
    {
        /// <summary>
        /// Defines the entry point of the application.
        /// </summary>
        /// <param name="args">The files to read.</param>
        private static void Main(string[] args)
        {
            var _class = new Class();

            Console.WriteLine("Processing files...");

            foreach(string filePath in args)
            {
                try
                {
                    _class.Reader = new TextFileReader(filePath);
                }
                catch
                {
                    Console.WriteLine($"Couldn't open file at '{filePath}'");
                    continue;
                }

                _class.Writer = new TextFileWriter(string.Join('_', new List<string> { filePath.TrimEnd(".txt".ToCharArray()), "_output.txt" }));
                _class.ReadFromFile();
                _class.WriteToFile();
            }

            Console.WriteLine("Processing of files successful");
            Console.WriteLine();
        }

    }

}
