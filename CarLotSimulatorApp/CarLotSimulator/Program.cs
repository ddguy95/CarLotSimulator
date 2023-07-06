using Microsoft.VisualBasic;
using System;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO

            //Create a seperate class file called Car - done
            //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
            //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
            //The methods should take one string parameter: the respective noise property

            CarLot carLotInstance = new CarLot();

            //Now that the Car class is created we can instanciate 3 new cars
            var instance1 = new Car();
            instance1.EngineNoise = "VROOM!";
            instance1.HonkNoise = "HOOOONK!";
            instance1.Make = "Toyota";
            instance1.Model = "Tundra";
            instance1.Year = 2023;

            carLotInstance.ListOfCars.Add(instance1);
            CarLot.numberOfCars++;
            Console.WriteLine($"There are {CarLot.numberOfCars} on the lot.");
            Console.WriteLine();

            Car instance2 = new Car()
            

            {
                EngineNoise = "ROOOOOAAAARRRRRR", 
                HonkNoise = "OOONNNN", 
                Make = "Dodge",
                Model = "Charger",
                IsDrivable = true
            };

            carLotInstance.ListOfCars.Add(instance2);
            CarLot.numberOfCars++;
            Console.WriteLine($"There are {CarLot.numberOfCars} on the lot.");
            Console.WriteLine();

            Car instance3 = new Car("Lexus", "RX350", 2023, "heyy", "what's up");

            carLotInstance.ListOfCars.Add(instance3);
            CarLot.numberOfCars++;
            Console.WriteLine($"There are {CarLot.numberOfCars} on the lot.");
            Console.WriteLine();

            //Set the properties for each of the cars
            //Call each of the methods for each car
            instance1.MakeEngineNoise();
            instance1.MakeHonkNoise(instance1.HonkNoise);

            //*************BONUS*************//

            // Set the properties utilizing the 3 different ways we learned about, one way for each car

            //*************BONUS X 2*************//

            //Create a CarLot class
            //It should have at least one property: a List of cars
            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console

            foreach (var item in carLotInstance.ListOfCars)
            {
                //Console.WriteLine(item.Year);
                //Console.WriteLine(item.Make);
                //Console.WriteLine(item.Model);
                //item.MakeEngineNoise();
                //item.MakeHonkNoise(item.HonkNoise);
                //Console.WriteLine();


            }
        }
    }
}
