using System;
using System.Collections.Generic;
using System.Text;

namespace DirectoryT
{
    class ActionNode
    {
        public ActionNode Next { get; set; }
        public ActionNode Prev { get; set; }
        public Folder folder { get; set; }
    }
}
