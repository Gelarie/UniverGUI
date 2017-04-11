using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUIexample
{
    class Temppass : Document
    {
        public int Numberdoc { get; set; }
        public string Namedoc { get; set; }
        public Temppass(int numberdoc, string namedoc)
        {
            this.Numberdoc = numberdoc;
            this.Namedoc = namedoc;
        }
    }
}
