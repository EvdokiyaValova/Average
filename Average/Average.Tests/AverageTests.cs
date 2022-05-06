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
    }
}