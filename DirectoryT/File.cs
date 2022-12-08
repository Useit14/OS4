// Проект по созданию модели логической файловой системы 
// Дочерний класс MyObject, созданный для указания конкретного типа созданного объекта (File)
using System;
using System.Collections.Generic;
using System.Text;

namespace DirectoryT
{
    class File : MyObject
    {
        public File(string name, Folder parent, int weight) : base(name, parent)
        {
            this._Weight = weight;
        }
    }
}