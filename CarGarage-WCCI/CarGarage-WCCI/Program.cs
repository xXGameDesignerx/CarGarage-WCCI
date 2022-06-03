using CarGarage_WCCI;
/*
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
*/
Console.WriteLine("Welcome to Dave's Garage!");
Console.WriteLine("How many vehicles would you like your garage to store?");
int capacity;
try
{
    capacity = Int32.Parse(Console.ReadLine());
}
catch (Exception e)
{
    capacity = 5;
}
Console.Clear();
Console.WriteLine("Your garage will store " + capacity + " vehicles!");
Console.WriteLine("press enter to continue.");
Console.ReadLine();
Garage garage = new Garage(capacity);
Vehicle activeVehicle;

Console.Clear();
Console.WriteLine("What type of vehicle would you like to start with?");
Console.WriteLine("1. Car \n2. Bicycle");
int vehicleType;
try
{
    vehicleType = Int32.Parse(Console.ReadLine());
}
catch (Exception e)
{
    vehicleType = 1;
}
if(vehicleType == 1)
{
    activeVehicle = new Cars();
}
else
{
    activeVehicle = new Bicycle("Ozone", false, BikeType.Mountain);
}
garage.Vehicles.Add(activeVehicle);
Console.WriteLine("You added a + " + activeVehicle.GetType() + " to the garage.");
Console.WriteLine("press enter to continue.");
Console.ReadLine();

bool isRunning = true;
while (isRunning)
{
    Console.Clear();
    Console.WriteLine("Welcome to Dave's Garage!");
    Console.WriteLine("1. Accelerate \n2. Brake \n3. Swap Vehicles \n4. Add Vehicle \n5. Remove Vehicle \n6. Display vehicles");

    int input;
    try
    {
        input = Int32.Parse(Console.ReadLine());
    }
    catch (Exception e)
    {

        input = -1;
    }

    switch (input)
    {
        case -1:
            Console.WriteLine("Please type a numeric value!");
            Console.WriteLine("press enter to continue.");
            Console.ReadLine();
            break;
        case 0:
            isRunning = false;
            break;
        case 1:
            isRunning = true;
            break;
        case 2:
            isRunning = false;
            break;
        case 3:
            isRunning = false;
            break;
        case 4:
            isRunning = false;
            break;
        case 5:
            Console.Clear();
            Console.WriteLine("What vehicle would you like to remove?");
            for (int i = 0; i < garage.Vehicles.Count; i++)
            {
                if (garage.Vehicles[i].GetType() == typeof(Cars))
                {
                    Cars temp = (Cars)garage.Vehicles[i];
                    Console.WriteLine(i + ". " + temp.Make + " - " + temp.Model);
                }
                else if (garage.Vehicles[i].GetType() == typeof(Bicycle))
                {
                    Bicycle temp = (Bicycle)garage.Vehicles[i];
                    Console.WriteLine(i + ". " + temp.Brand);
                }
            }
            int vehicleChoice;
            try
            {
                vehicleChoice = Int32.Parse(Console.ReadLine());
                garage.Vehicles.RemoveAt(vehicleChoice);
                Console.WriteLine("You removed " + vehicleChoice);
                Console.WriteLine("press enter to continue.");
                Console.ReadLine();
            }
            catch (Exception e)
            {

                Console.Clear();
                Console.WriteLine("You have not removed your vehicle");
                Console.WriteLine("press enter to continue.");
                Console.ReadLine();
            }
            break;
        case 6:
            isRunning = false;
            break;
        default:
            Console.WriteLine("i don't understand that!");
            Console.WriteLine("press enter to continue.");
            Console.ReadLine();
            break;
    }
}