using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars
{
    /// <summary>
    /// Класс, хранящий информацию о легковом транспорте.
    /// </summary>
    public class EasyCar : Car
    {
        /// <summary>
        /// Свойство автомобиля, обозначающее его название.
        /// </summary>
        private string carName;

        /// <summary>
        /// Свойство автомобиля, обозначающее его двигатель.
        /// </summary>
        private Engine carEngine;

        /// <summary>
        /// Свойство автомобиля, обозначающее его разрешенную максимальную массу. 
        /// </summary>
        private string typeCar;

        /// <summary>
        /// Конструктор для объекта класса HardCar
        /// </summary>
        /// <param name="name">Переменная для обозначения названия автомобиля.</param>
        /// <param name="engine">Переменная для обозначения двигателя автомобиля.</param>
        /// <param name="type">Переменная для обозначения типа автомобиля.</param>
        public EasyCar(string name, Engine engine, string type) : base(name, engine)
        {
            carName = name;
            carEngine = engine;
            typeCar = type;
        }

        /// <summary>
        /// Метод для отображения информации о типе автомобиля.
        /// </summary>
        public void ShowType()
        {
            Console.WriteLine("Данная машина является легковой");
        }
        
        /// <summary>
        /// Метод для показа того, что объект является машиной.
        /// </summary>
        public void SimpleString()
        {
            Console.WriteLine("ЭТО МАШИНА!");
        }
    }
}
