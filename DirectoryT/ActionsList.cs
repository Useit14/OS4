using System;
using System.Collections.Generic;
using System.Text;

namespace DirectoryT
{
    class ActionsList
    {
        
        ActionNode first;
        ActionNode last;
        int count;
        ActionNode current;
        public void Append(Folder newFolder)
        {
            current = new ActionNode();
            current.folder = newFolder;
            if (first == null && last == null)
            {
                first = current;
                last = current;
            }
            else
            {
                current.Prev = last;
                last.Next = current;
                last = current;
            }
            count++;
        }
        public void Prepend(Folder newFolder)
        {
            current = new ActionNode();
            current.folder = newFolder;
            if (first == null && last == null)
            {
                first = current;
                last = current;
            }
            else
            {
                current.Next = first;
                first.Prev = current;
                first = current;
            }
            count++;
        }
        public void NewNext()
        {
               
        }
    }
}
