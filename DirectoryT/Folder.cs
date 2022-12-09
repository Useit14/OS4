// Проект по созданию модели логической файловой системы 
// Дочерний класс MyObject, созданный для указания конкретного типа созданного объекта (Folder)

using System;
using System.Collections.Generic;
using System.Text;

namespace DirectoryT
{
    class Folder : MyObject
    {
        public List<MyObject> Children;
        private MyObject Buffer;
        public Folder() : base()
        {
            _Name = "Этот компьютер";
            _Path = _Name;
            Children = new List<MyObject>();
        }
        public Folder(string name, Folder parent) : base(name, parent)
        {
            Children = new List<MyObject>();
        }
        public void Add_Child(MyObject Child)
        {
            Children.Add(Child);
        }
        public void Delete_Child(int index)
        {
            if (_Name != "Этот компьютер")
                Children.RemoveAt(index);
            else
            {
                throw new Exception("Cannot be used in the root directory");
            }
        }
        public List<MyObject> Return_Children()
        {
            return Children;
        }
        public int CountName(string name)
        {
            int count = 0;

            foreach (MyObject obj in Children)
            {
                var a = obj._Name.Split(" -");
                if (a.Length > 1)
                    if (a[0] == name && a[1] == "Копия")
                        count++;
            }
            return count;
        }
        public void SortByName()
        {
            Children.Sort((x, y) => x._Name.CompareTo(y._Name));
        }
        public void SortByType()
        {
            Children.Sort((x, y) => x.GetType().ToString().CompareTo(y.GetType().ToString()));
        }
        public void SortByWeight()
        {
            Children.Sort((x, y) => x._Weight.CompareTo(y._Weight));
        }

        public void SetBuffer(MyObject myObject)
        {
            Buffer = myObject;
        }

        public MyObject GetBuffer()
        {
            return Buffer;
        }

    }
}
