using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    internal interface City
    {
        Human[] humans { get;}
        public void AddHuman(Human human);

        public Human[] SearchHumans(string search);

    

    }
}
