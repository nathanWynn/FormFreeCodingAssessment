using PrimeFactorizationLibrary;
using System;
using System.Collections.Generic;
using System.IO;
using Xunit;

namespace UnitTests
{
    public class PrimeFactorizationLibraryTests
    {
        
        [Fact]
        public void ValidFileTest()
        {
            List<List<int>> expected = new List<List<int>>();
            expected.Add(new List<int> { 2, 3, 13, 157 });
            expected.Add(new List<int> { 2, 2, 2, 2, 11, 197 });
            expected.Add(new List<int> { 2, 2, 2, 2, 2, 5, 5, 5, 5, 5 });
            expected.Add(new List<int> { 3, 3, 3607, 3803 });            

            List<List<int>> actual = PrimeFactorDocumentUtils.GetFactorizations(@"TestFiles/ValidPrimeFactorizationTest.txt");
            Console.WriteLine(actual);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void NullFileTest()
        {
            List<List<int>> actual;
            Assert.Throws<ArgumentNullException>(() => actual = PrimeFactorDocumentUtils.GetFactorizations(null));
        }

        [Fact]
        public void FileNotFoundTest()
        {
            List<List<int>> actual;
            Assert.Throws<FileNotFoundException>(() => actual = PrimeFactorDocumentUtils.GetFactorizations(@"TestFiles/DoesNotExist.txt"));
        }

        [Fact]
        public void InvalidFileTypeTest()
        {
            List<List<int>> actual;
            Assert.Throws<ArgumentException>(() => actual = PrimeFactorDocumentUtils.GetFactorizations(@"TestFiles/WrongFile.csv"));
        }

        [Fact]
        public void NegativeNumberTest()
        {
            List<List<int>> actual;
            Assert.Throws<ArgumentException>(() => actual = PrimeFactorDocumentUtils.GetFactorizations(@"TestFiles/InvalidTestWithNegatives.txt"));
        }
    }
}