using System;


namespace Lecture18
{
	class Truck : Car
	{
		private double loadAmount = 0;
		private double capacity;


		public Truck(Engine engine, GasTank gasTank, double capacity, string plateNumber) :
			base(engine, gasTank, plateNumber)
		{
			this.capacity = capacity;
		}


		public double LoadAmount
		{
			get {
				return loadAmount;
			}
		}


		public override double LitersPerKm
		{
			get {
				return 3.0 / 100 + loadAmount / 1000;
			}
		}


		public override void Go(double distance)
		{
			base.Go(distance);
			Console.WriteLine("Transported {0} stuff.", loadAmount);
		}


		public void Load(double amount)
		{
			if (amount + loadAmount > capacity) {
				throw new ArgumentException();
			}
			loadAmount += amount;
		}


		public void Unload(double amount)
		{
			if (amount > loadAmount) {
				throw new ArgumentException();
			}
			loadAmount -= amount;
		}

		public override void Honk()
        {
			Console.WriteLine("Truck honk.");
        }
		public double UnloadAll()
        {
			double amount = loadAmount;
			loadAmount = 0;
			return amount;
        }
	}
}