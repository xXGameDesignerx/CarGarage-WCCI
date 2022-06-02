using CarGarage_WCCI;

namespace CarGarage_Test
{
    // classes can have properties and methods
    public class Tests
    {
        private Cars _car;
        private Cars _emptyCar;
        private Bicycle _bicycle;

        [SetUp] // tags - used to identify something like a method.
        public void Setup()
        {
            // arrange 
            _emptyCar = new Cars();
            _car = new Cars("Chevrolet", "Camaro", 22, 100, 0, 184);
            _bicycle = new Bicycle("Ozone", false, BikeType.Mountain);
        }

        [Test]
        public void Car_Accelerate_Should_Increase_Speed_By_5()
        {
            // act
            _car.Accelerate();
            // assert
            Assert.AreEqual(5,_car.Speed);
        }
    }
}