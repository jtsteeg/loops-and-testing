using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Warm_up_loops;
namespace Warm_up_loops_tests
{
    [TestClass]
    public class ForLoops_tests
    {
        [TestMethod]
        public void GetLowest_ArrayWithMinValue_ReturnsLowestNumber()
        {
            //Arrange
            var sut = new ForLoop();
            var arr = new System.Int32[] { -2, -5, 7, 2000, Int32.MinValue, 25 };
            var expected = Int32.MinValue;

            //Act
            var result = sut.GetLowest(arr);

            //Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void GetLowest_EmptyArray_ReturnsNull()
        {
            //Arrange
            var sut = new ForLoop();
            var arr = new int[] { };
            int? expected = null;

            //Act
            var result = sut.GetLowest(arr);

            //Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void GetLowest_NumbersLargerThanZero_ReturnLowestNumber()
        {
            //Arrange
            var sut = new ForLoop();
            var arr = new int[] { Int32.MaxValue, 9999, 3909090 };
            var expected = 9999;

            //Act
            var result = sut.GetLowest(arr);

            //Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void GetHighest_ArrayWithMinValueAndNegatives_ReturnsHighestNumber()
        {
            //Arrange
            var sut = new ForLoop();
            var arr = new int[] { -2, -5, -7, -2000, Int32.MinValue, -25 };
            var expected = -2;

            //Act
            var result = sut.GetHighest(arr);

            //Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void GetHighest_EmptyArray_ReturnNull()
        {
            //Arrange
            var sut = new ForLoop();
            var arr = new System.Int32[] { };
            int? expected = null;

            //Act
            var result = sut.GetHighest(arr);

            //Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void GetHighest_NumbersLargerThanZero_ReturnsHighest()
        {
            //Arrange
            var sut = new ForLoop();
            var arr = new System.Int32[] { Int32.MaxValue, 9999, 3909090 };
            var expected = Int32.MaxValue;

            //Act
            var result = sut.GetHighest(arr);

            //Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void GetHighest_JaggedArray_ReturnsHighestNumber()
        {
            //Arrange
            var sut = new ForLoop();
            var arr = new System.Int32[][]
            {
                new int[] { -10, 3, 6},
                new int[] { 1, 3, 6, 9, 999},
                new int[] { 1000, 3, 6},
            };
            var expected = 1000;

            //Act
            var result = sut.GetHighest(arr);

            //Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void GetHighest_EmptyJaggedArray_ReturnNull()
        {
            //Arrange
            var sut = new ForLoop();
            var arr = new System.Int32[][] { };
            int? expected = null;

            //Act
            var result = sut.GetHighest(arr);

            //Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void GetHighest_EmptyArraysInJaggedArray_ReturnNull()
        {
            //Arrange
            var sut = new ForLoop();
            var arr = new System.Int32[][]
            {
                new int[] { },
                new int[] { },
            };
            int? expected = null;

            //Act
            var result = sut.GetHighest(arr);

            //Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void GetHighest_JaggedArrayItemsLargerThanZero_ReturnsHighest()
        {
            //Arrange
            var sut = new ForLoop();
            var arr = new System.Int32[][]
            {
                new int[] { },
                new int[] { Int32.MaxValue, 9999, 3909090 }
            };
            var expected = Int32.MaxValue;

            //Act
            var result = sut.GetHighest(arr);

            //Assert
            Assert.AreEqual(expected, result);
        }
    }
}
