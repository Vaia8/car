using System;


namespace Lecture18
{
	class Car
	{
		// protected je viditelné i v podtřídě
		protected Engine engine;

		protected GasTank gasTank;

		protected string plateNumber;

		public Car(Engine engine, GasTank gasTank, string plateNumber)
		{
			this.engine = engine;
			this.gasTank = gasTank;
			this.plateNumber = plateNumber;
		}

		virtual public double LitersPerKm
		{
			get {
				return 2.0 / 100;
			}
		}


		public void Tank(double amount)
		{
			gasTank.Add(amount);
		}

		public virtual void Honk()
        {
			Console.WriteLine("Car honk.");
        }
		public virtual void Go(double distance)
		{
			double realDistance = engine.Run(this, distance, gasTank);
			double time = engine.Time(realDistance);
			Console.WriteLine("Car with plate number {0} went {1} km in {2} hours. {3} liters of gas left.", plateNumber, realDistance, time, gasTank.Amount);
		}
	}
}