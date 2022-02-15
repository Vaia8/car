﻿// https://docs.microsoft.com/en-us/dotnet/csharp/fundamentals/object-oriented/inheritance
// https://docs.microsoft.com/en-us/dotnet/csharp/fundamentals/object-oriented/polymorphism
// https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/this
// https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/base
// https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/virtual
// https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/override
// (https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/new-modifier)

using System;


namespace Lecture18
{
	class Program
	{
		static void Main(string[] args)
		{
			Car car = new Car(new Engine(150, 5.0 / 100), new GasTank(40.0), "2A71452");
			car.Tank(40.0);
			car.Go(500);

			Truck truck = new Truck(
				new Engine(100, 10.0 / 100),
				new GasTank(100.0),
				20.0,
				"3B82563"
			);
			truck.Load(20.0);
			truck.Tank(100.0);
			truck.Go(250);
			truck.Unload(10.0);
			truck.Go(250);
			truck.UnloadAll();
			truck.Go(250);

			Car[] fleet = { car, truck };

			foreach (Car fleetCar in fleet) {
				// fleetCar.load(20);
				if (fleetCar is Truck fleetTruck) {
					fleetTruck.Load(20);
					fleetTruck.UnloadAll();
				}
				fleetCar.Tank(60.0);
				fleetCar.Go(250);
				fleetCar.Honk();
			}

			Console.ReadKey();
		}
	}
}
