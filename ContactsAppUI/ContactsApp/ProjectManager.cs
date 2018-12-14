using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace ContactsApp
{
    /// <summary>
    /// Класс для сериализации и дессириализации
    /// </summary>
    public static class ProjectManager
    {
        /// <summary>
        /// Константа с путем и именем фаила
        /// </summary>
        const string _file = @"C:\Users\Админ\Desktop\Учеба\НтВП\Project\ContactsApp.notes"; //Environment сделать условным
        /// <summary>
        /// Запись в фаил
        /// </summary>
        /// <param name="data">
        /// Список записываемых заметок
        /// </param>
        public static void SaveToFile(Project data)
        {
            using (StreamWriter file = File.CreateText(_file))
            {
                JsonSerializer serializer = new JsonSerializer();
                serializer.Serialize(file, data);
            }
        }

        /// <summary>
        /// Чтение из фаила
        /// </summary>
        /// <returns>
        /// Список заметок
        /// </returns>
        public static Project LoadFromFile()
        {
            using (StreamReader file = File.OpenText(_file))
            {
                JsonSerializer serializer = new JsonSerializer();
                return (Project)serializer.Deserialize(file, typeof(Project));
            }
        }
    }
}
