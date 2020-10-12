﻿using SpeedRacing;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SpeedRacing
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Car> cars = new List<Car>();
            

            for (int i = 0; i < n; i++)
            {
                string[] inputinfo = Console.ReadLine().Split(" ");

                string model = inputinfo[0];
                double fuelAmount = double.Parse(inputinfo[1]);
                double fuelConsumption = double.Parse(inputinfo[2]);

                Car car = new Car(model, fuelAmount, fuelConsumption);
                cars.Add(car);
            }

            string input = Console.ReadLine();

            while (input != "End")
            {
                string[] data = input.Split(" ");
                string model = data[1];
                int amountOfKm = int.Parse(data[2]);

                Car car = cars.FirstOrDefault(x => x.Model == model);

                car.Drive(amountOfKm);

                input = Console.ReadLine();
            }

            foreach (var car in cars)
            {
                Console.WriteLine($"{car.Model} {car.FuelAmount:f2} {car.TravelledDistance}");
            }
        }

        
    }
}
