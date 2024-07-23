using NUnit.Framework;
using System;
using YouSourceCodingExam.Class;

namespace YouSourceCodingExamTest
{
    [TestFixture]
    public class SortStrategyTests
    {

        //Sorting Test
        [Test]
        public void BubbleSort_SortsCorrectly()
        {
            // Arrange
            var strategy = new BubbleSortStrategy();
            string input = "befdac";
            string expected = "abcdef";

            // Act
            string result = strategy.Sort(input);

            // Assert
            Assert.AreEqual(expected, result);
        }


        [Test]
        public void QuickSort_SortsCorrectly()
        {
            // Arrange
            var strategy = new QuickSortStrategy();
            string input = "befdac";
            string expected = "abcdef";

            // Act
            string result = strategy.Sort(input);

            // Assert
            Assert.AreEqual(expected, result);
        }

        //Empty String Test
        [Test]
        public void BubbleSort_EmptyString_ReturnsEmpty()
        {
          
            var strategy = new BubbleSortStrategy();
            string input = "";
            string expected = "";

           
            string result = strategy.Sort(input);

         
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void QuickSort_EmptyString_ReturnsEmpty()
        {
          
            var strategy = new QuickSortStrategy();
            string input = "";
            string expected = "";

          
            string result = strategy.Sort(input);

          
            Assert.AreEqual(expected, result);
        }

        //Validation Test
        [Test]
        public void BubbleSort_NullString_ReturnsNull()
        {
            // Arrange
            var strategy = new BubbleSortStrategy();
            string input = null;
            string expected = null;

            // Act
            string result = strategy.Sort(input);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void QuickSort_NullString_ThrowsArgumentNullException()
        {
            // Arrange
            var strategy = new QuickSortStrategy();
            string input = null;

            // Act & Assert
            var ex = Assert.Throws<ArgumentNullException>(() => strategy.Sort(input));
            Assert.That(ex.Message, Is.EqualTo("Input cannot be null. (Parameter 'input')"));
        }



    }
}


