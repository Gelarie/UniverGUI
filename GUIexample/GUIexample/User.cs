using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUIexample
{
    class User
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string LastName { get; set; }

        public User(int id, string firstname, string secondname, string lastname)
        {
            this.ID = id;
            this.FirstName = firstname;
            this.SecondName = secondname;
            this.LastName = lastname;
        }
        public void GetTemppass(int numberdoc, string namedoc)
        {
            
        }
    }
}
