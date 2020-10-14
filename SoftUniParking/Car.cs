using System;
using System.Collections.Generic;
using System.Text;

namespace SoftUniParking
{
    public class Car
    {
        public Car(string make, string model, int horsePower, string registratioNumber)
        {
            Make = make;
            Model = model;
            HorsePower = horsePower;
            RegistratioNumber = registratioNumber;
        }

        public string Make { get; set; }

        public string Model { get; set; }

        public int HorsePower { get; set; }

        public string RegistratioNumber { get; set; }


        public override string ToString()
        {
            StringBuilder sb = new StringBuilder(0);

            sb.AppendLine($"Make: {Make}");
            sb.AppendLine($"Model: {Model}");
            sb.AppendLine($"HorsePower: {HorsePower}");
            sb.AppendLine($"RegistratioNumber: {RegistratioNumber}");
            return sb.ToString().TrimEnd();

        }

    }
}
