using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars
{
    public abstract class Car
    {

        /// <summary>
        /// Свойство автомобиля, обозначающее его название.
        /// </summary>
        private string nameCar;

        /// <summary>
        /// Свойство автомобиля, обозначающее его двигатель.
        /// </summary>
        private Engine engine;

        /// <summary>
        /// Свойство автомобиля, обозначающее его колеса.
        /// </summary>
        //private Wheels wheels;

        /// <summary>
        /// Конструктор для объекта класса Car
        /// </summary>
        /// <param name="carName">Переменная для обозначения названия автомобиля</param>
        /// <param name="carEngine">Переменная для обозначения двигателя автомобиля</param>
        /// <param name="carWheels">Переменная для обозначения колес автомобиля</param>
        public Car(string carName, Engine carEngine /*Wheels carWheels*/)
        {
            nameCar = carName;
            engine = carEngine;
            //wheels = carWheels;
        }

        /// <summary>
        /// Метод для сохранения информации о двигателе автомобиля.
        /// </summary>
        /// <param name="carEngine"> Переменная, обозначающая двигатель автомобиля.</param>
        public void SetEngine(Engine carEngine)
        {
            engine = carEngine;
        }

        /// <summary>
        /// Метод для сохранения информации о колесах автомобиля
        /// </summary>
        /// <param name="carWheels">Переменная, обозначающая колеса автомобиля</param>
        /*public void SetWheels(Wheels carWheels)
        {
            wheels = carWheels;
        }*/

        /// <summary>
        /// Метод для получения информации об автомобиле
        /// </summary>
        public void ShowCarInfo()
        {
            Console.WriteLine($"Car: {nameCar}");
            Console.WriteLine($"Engine: {engine.GetEngineInfo()}");
            //Console.WriteLine($"Wheels: {wheels.GetWheelsInfo()}");
        }
    }
}
