using System;
using System.Collections.Generic;

namespace lab3task1_2_3
{
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public IEnumerable<string> PhoneNumbers { get; set; }
    }
}
