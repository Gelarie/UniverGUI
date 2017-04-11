using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUIexample
{
    class Student : User
    {
         Student(int id, string firstname, string secondname, string lastname) : base(id, firstname, secondname, lastname)
        {
            
        }
        public void GetCard()
        {

        }
    }
}
