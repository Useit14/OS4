// Проект по созданию модели логической файловой системы 
// Данный класс предназначен для созддания собственного типа данных, в проекте
// Класс MyObject разделенн на два подкласса File и Folder

using System;
using System.Collections.Generic;
using System.Text;

namespace DirectoryT
{
    public class MyObject
    {
        public string _Name;                // Имя объекта 
        public string _Path;                // Путь объекта
        public MyObject _Parent;            // родительская папка объекта
        public int _Weight;                 // Вес объекта, папки без веса(Null)
        public int CountIs;                 // Количество дублированных объектов в текущей дериктории
        public MyObject()
        {
        }
        //
        // Сводка:
        //      Конструктор класса
        //
        // Параметры:
        //  name:
        //      Принимает имя объекта
        //
        //  parent:
        //      Принимает текущюю дерикторию объекта
        //
        // Исключения:
        //  Cannot be created in the root directory:
        //      Попытка создать в корневом каталоге
        //
        public MyObject(string name, MyObject parent)
        {
            Folder par = parent as Folder;
            int i = 2;
            string dublicateName = name;
            foreach (MyObject child in par.Return_Children())
            {
                if (child._Name == dublicateName)
                {
                    dublicateName = name + $"({i})";
                    i++;
                }
            }
            name = dublicateName;
            if (parent._Name != "Этот компьютер" || name == "C:")
            {
                this._Name = name;
                this._Path = parent._Path + "\\" + _Name;
                this._Parent = parent;
                var p = this._Parent as Folder;
                p.Add_Child(this);
            }
            else
            {
                throw new Exception("Cannot be created in the root directory");
            }
        }
        //
        // Сводка:
        //      Метод для переименовки объекта
        //
        // Параметры:
        //  name:
        //      Принимает новое имя объекта
        //
        // Исключения:
        //  Using invalid symbols:
        //      Использованны недопустиммые символы (/ \ : * + ? “ < >)
        //
        public void ReName(string name)
        {
            if (_Parent._Name != "Этот компьютер")
            {
                if (name != _Name)
                {
                    Folder par = this._Parent as Folder;
                    int i = 2;
                    string dublicateName = name;
                    foreach (MyObject child in par.Return_Children())
                    {
                        if (child._Name == dublicateName)
                        {
                            dublicateName = name + $"({i})";
                            i++;
                        }
                    }
                    foreach (Char s in name)
                    {
                        if (Char.IsSymbol(s) || Char.IsPunctuation(s))
                        {
                            throw new Exception("Using invalid symbols");
                        }
                    }
                    name = dublicateName;
                    this._Name = name;
                    this._Path = _Parent._Path + "\\" + _Name;
                }
            }
            else
            {
                throw new Exception("Cannot be used in the root directory");



            }
        }
    }
}
