using CarGarage_WCCI;

Cars davisCar = new Cars(); // RED FLAG! 'new' means we are creating a new object (often paired with a constructor)
Console.WriteLine(davisCar.Model);

Cars xavierCar = new Cars("Chevrolet", "Camaro", 22, 100, 0, 184);
// calling model method
Console.WriteLine(xavierCar.Model);
// calling speed method
Console.WriteLine(xavierCar.Speed);
xavierCar.Accelerate();
// updating the method 
Console.WriteLine(xavierCar.Speed);

// cloning example
//Cars adenCar = davisCar;
//davisCar = new Cars();

// variable declaration
// type name;

// assignment/reassignment
// name = value;
bool isSunny = true;

// temperature with ternary statements
int temperature;

if(isSunny)
{
    temperature = 90;
}
else
{
    temperature = 60;
}
// ternary example
// type variable = condition ? ValT : ValF; - ternary statements simplify to a value, and could be used anywhere where a value is used
int ternaryTemp = isSunny ? 90 : 60;

Console.WriteLine(temperature);
Console.WriteLine(ternaryTemp);