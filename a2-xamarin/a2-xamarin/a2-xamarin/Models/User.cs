using System;
using System.Collections.Generic;
using System.Text;

namespace a2_xamarin.Models
{
    class User
{
        public string Name { get; set; }
        public int Posts { get; set; }
        public int Comments { get; set; }
        public override string ToString()
        {
            return Name;
        }
    }
}
