using System;
using System.Collections.Generic;
using System.Text;

namespace BlazorWebAssemblyApp.Shared
{
    public class MyHeros
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string HeroName { get; set; }
        public comic Comic { get; set; }
    }
}
