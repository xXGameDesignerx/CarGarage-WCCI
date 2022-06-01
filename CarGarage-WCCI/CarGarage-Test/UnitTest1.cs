using CarGarage_WCCI;

namespace CarGarage_Test
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
            Cars car = new Cars();
        }

        [Test]
        public void Test1()
        {
            Assert.Pass();
        }
    }
}