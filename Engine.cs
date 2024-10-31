using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars
{

    /// <summary>
    /// Класс, отвечающий за хранение информации о двигателях.
    /// </summary>
    public class Engine
    {
        /// <summary>
        /// Свойство для обозначения названия двигателя
        /// </summary>
        private string name;

        /// <summary>
        /// Свойство для обозначения номера двигателя
        /// </summary>
        private int id;

        /// <summary>
        /// Свойство для обозначения страны-производителя двигателя
        /// </summary>
        private string country;

        /// <summary>
        /// Конструктор для объекта класса Engine
        /// </summary>
        /// <param name="nameEngine">Переменная для названия двигателя</param>
        /// <param name="idEngine">Переменная для номера двигателя</param>
        /// <param name="countryMakeEngine">Переменная для страны-производителя двигателя</param>
        public Engine(string nameEngine, int idEngine, string countryMakeEngine)
        {
            name = nameEngine;
            id = idEngine;
            country = countryMakeEngine;
        }

        /// <summary>
        /// Метод для получения информации о двигателе
        /// </summary>
        /// <returns>Информация о двигателе(его название, номер и страну-производителя</returns>
        public string GetEngineInfo()
        {
            return $"{name}, ID: {id}, Country: {country}";
        }
    }
}
