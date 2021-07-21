using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFTutorial
{
    public class UserData
    {
        public string name { get; set; }
        public string surname { get; set; }
        public uint age { get; set; }

        public UserData()
        {
            name = "";
            surname = "";
            age = 0;
        }
        public UserData(string a_name, string a_password, uint a_age)
        {
            name = a_name;
            surname = a_password;
            age = a_age;
        }
    }
}
