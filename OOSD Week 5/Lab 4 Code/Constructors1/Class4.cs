using System;

namespace Classes4
{
	/// <summary>
	/// Summary description for Class1.
	/// </summary>
	class Class4
	{
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main(string[] args)
			{
				Cars car1 = new Cars();// contructor method with no arguments passed
				car1.Colour="Red";
				car1.Make="Ford";
				car1.Type="Mondeo";
				car1.Cost=15000;
				Console.WriteLine(
					"Car1 is a" + 
					" " + car1.Country + 
					" " + car1.Make + 
					" " + car1.Type +
					" " + car1.Colour +
					" " + car1.Cost
					);

			Cars car2 = new Cars("Vauxhall");// contructor method with one argument passed
			car2.Colour="Blue";
			car2.Type="Astra";
			car2.Cost=20000;
			Console.WriteLine(
				"Car2 is a" + 
				" " + car2.Country + 
				" " + car2.Make + 
				" " + car2.Type +
				" " + car2.Colour +
				" " + car2.Cost
				);

            Cars car3 = new Cars("Volkswagen", "Golf");// contructor method with two argument passed
            car3.Colour = "Black";
            car3.Cost = 30000;
            Console.WriteLine(
                "Car3 is a" +
                " " + car3.Country +
                " " + car3.Make +
                " " + car3.Type +
                " " + car3.Colour +
                " " + car3.Cost
                );

            Cars car4 = new Cars("Audi", "R3", "White");// contructor method with three argument passed
            car4.Cost = 40000;
            Console.WriteLine(
                "Car4 is a" +
                " " + car4.Country +
                " " + car4.Make +
                " " + car4.Type +
                " " + car4.Colour +
                " " + car4.Cost
                );

            Console.ReadLine();
			}
	}
}
