using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLiteDEmo
{
    internal class Category
    {
        private string _name;
        public string Name { get { return _name; } }
        public Category(string name) 
        {
            _name = name;
        }
        public string AddCategory()
        {
            string result = $"INSERT INTO " +
                "Category" +
                "(Name) " + // Поле в базе данных
                "VALUES" +
                $"('{Name}');"; // $ в строковую переменную вставляет внешнюю переменную и преобразует её в строку
            return result;
        }
    }
}
