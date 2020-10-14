using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SoftUniParking
{
     public class Parking
    {
        private List<Car> cars;
        private int capacity;

        public Parking(int capacity)
        {
            this.capacity = capacity;
            this.cars = new List<Car>();

        }

        public int Count => this.cars.Count;


        public string AddCar(Car car)
        {
            if (cars.Any(x => x.RegistratioNumber == car.RegistratioNumber))
            {
                return"Car with that registration number, already exists!";
            }

            if (capacity == cars.Count)
            {
               return"Parking is full!";
            }
            cars.Add(car);

            return $"Successfully added new car {car.Make} {car.RegistratioNumber}";
        }

        public string RemoveCar( string registrationNumber)
        {
            Car car = cars.FirstOrDefault(x => x.RegistratioNumber == registrationNumber);
            if (car == null)
            {
                return "Car with that registration number, doesn't exist!";
            }
            cars.Remove(car);
            return $"Successfully removed {registrationNumber}";
        }

        public Car GetCar(string registrationNumber)
            => cars.FirstOrDefault(x => x.RegistratioNumber == registrationNumber);

        public void remuveSetOfRegistrationNumber(List<string> registrationNumber)
        {
            foreach (var RegistratioNumberber in registrationNumber)
            {
                var car = cars.FirstOrDefault(x => x.RegistratioNumber == RegistratioNumberber);
                cars.Remove(car);
            }
        }

    }
}
