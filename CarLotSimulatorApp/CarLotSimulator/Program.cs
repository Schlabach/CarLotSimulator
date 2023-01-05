using System;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO

            //Create a seperate class file called Car
            //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
            //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
            //The methods should take one string parameter: the respective noise property

            CarLot lot = new CarLot();

            var truck = new Car();
            lot.CarList.Add(truck);
            truck.Year = 2015;
            truck.Make = "Chevy";
            truck.Model = "Silverado";
            truck.EngineNoise = "Vroom";
            truck.HonkNoise = "Ahooga";
            truck.IsDrivable = true;

            truck.MakeHonkNoise();
            truck.MakeEngineNoise();
            Console.WriteLine($"Number of cars created: {CarLot.numberOfCars}");


            var van = new Car();
            lot.CarList.Add(van);
            van.Year = 2018;
            van.Make = "Honda";
            van.Model = "Odyssey";
            van.EngineNoise = "Rrrrr";
            van.HonkNoise = "Beep Beep";
            van.IsDrivable = true;

            van.MakeHonkNoise();
            van.MakeEngineNoise();
            Console.WriteLine($"Number of cars created: {CarLot.numberOfCars}");


            var suv = new Car();
            lot.CarList.Add(suv);
            suv.Year = 2020;
            suv.Make = "Toyota";
            suv.Model = "Highlander";
            suv.EngineNoise = "Brrrr";
            suv.HonkNoise = "Honk";
            suv.IsDrivable = false;

            suv.MakeHonkNoise();
            suv.MakeEngineNoise();
            Console.WriteLine($"Number of cars created: {CarLot.numberOfCars}");



            //Now that the Car class is created we can instanciate 3 new cars
            //Set the properties for each of the cars
            //Call each of the methods for each car

            //*************BONUS*************//

            // Set the properties utilizing the 3 different ways we learned about, one way for each car

            //*************BONUS X 2*************//


            foreach (var car in lot.CarList)
            {
                Console.WriteLine($"Year: {car.Year} Make: {car.Make} Model: {car.Model}");

            }

            //Create a CarLot class
            //It should have at least one property: a List of cars
            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console
        }
    }
}
