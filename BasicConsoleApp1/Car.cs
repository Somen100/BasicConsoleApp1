using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicConsoleApp1
{

    // for chapter 11
    public class Car
    {
        private string color; // Make of the car
        private double speed;
        private double maxSpeed;


        public Car(double sp, string cl, double ms)
        {
            color = cl;
            speed = sp;
            maxSpeed = ms;
        }

        public void accelerate(double increaseSpeed)
        {
            // When speed button is pushed, it increases the speed
            speed = speed + increaseSpeed;
            Console.WriteLine($"Accelerated Speed: {speed}");
        }

        public void PrintCarDetails(Car car)
        {
            Console.WriteLine($"Color: {car.color} and Speed: {car.speed}");

        }
        // method for Q.4********************************************************
        public void PrintCarMaxSpeed(Car car)
        {
            Console.WriteLine($"Max Speed: {car.maxSpeed} ");

        }
    }


    // class for Q.5*************************************
    //Write a program on creating multiple objects of one class in c# 
    public class BgColor
    {
        public string color = "red";

    }
}
