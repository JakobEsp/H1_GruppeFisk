using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H1_Fisketank
{
    class Fish
    {
        public string name { get; set; } = "No name yet";
        public int age { get; set; }
        public string species { get; set; }
        public double lenght { get; set; }
        public double weight { get; set; }
        public string[] types { get; set; }
    }
    public class Aquarium
    {
        List<Fish> fishList= new();
    }
}
