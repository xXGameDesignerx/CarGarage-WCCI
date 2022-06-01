using CarGarage_WCCI;

Cars davisCar = new Cars(); // RED FLAG! 'new' means we are creating a new object (often paired with a constructor)
Console.WriteLine(davisCar.Model);

Cars xavierCar = new Cars("Chevrolet", "Camaro", 22, 100, 0, 184);
Console.WriteLine(xavierCar.Model);

// cloning example
//Cars adenCar = davisCar;
//davisCar = new Cars();