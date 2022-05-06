using NUnit.Framework;

namespace Average.Tests
{
    public class AverageTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test_EmptyArray()
        {
            //Arrange 
            var arr = new int[] { };

            //Act
            var average = Average.AverageArr(arr);


            //Assert
            Assert.AreEqual(0 , average);
        }

        [Test]
        public void TwoPositiveNumbers()
        {
            //Arrange 
            var arr = new int[] { 2, 5};

            //Act
            var average = Average.AverageArr(arr);


            //Assert
            Assert.AreEqual(3.5, average);
        }

        [Test]
        public void FivePositiveNumbers()
        {
            //Arrange 
            var arr = new int[] { 2, 5, 8, 10, 20 };

            //Act
            var average = Average.AverageArr(arr);


            //Assert
            Assert.AreEqual(9, average);
        }

        [Test]
        public void TwoNegativeNumbers()
        {
            //Arrange 
            var arr = new int[] { -2, -5 };

            //Act
            var average = Average.AverageArr(arr);


            //Assert
            Assert.AreEqual(-3.5, average);
        }

        [Test]
        public void TwoNegativeAndOnePositiveNumbers()
        {
            //Arrange 
            var arr = new int[] { -2, -5, 9 };

            //Act
            var average = Average.AverageArr(arr);


            //Assert
            Assert.AreEqual(0.6666666666666666, average);
        }

        [Test]
        public void BiggerNumbers()
        {
            //Arrange 
            var arr = new int[] { 2000000000, 2000000000, 2000000000 };

            //Act
            var average = Average.AverageArr(arr);


            //Assert
            Assert.AreEqual(2000000000, average);
        }
    }
}