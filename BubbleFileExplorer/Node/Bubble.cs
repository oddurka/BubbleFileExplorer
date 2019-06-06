using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace BubbleFileExplorer.Node
{
    class Bubble
    {
        public String Title { get; set; }
        public bool expanded = false;
        public string[] filePaths = Directory.GetFiles(@"C:\Users\TheIc\Documents\Minecraft");

        public void Expand(string[] filePaths)
        {

        }

        public void Collapse()
        {

        }
    }
}
