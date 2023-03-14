using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor_Assignment
{
    public class ConstructMe
    {
        public string name;
        public int id;
        public ConstructMe(string Name, int id)
        {
            this.name = Name;
            this.id = id;
        }

    }
    class cnstrct
    {
        static void Main(string[] args)
        {
            var a  = new ConstructMe("Daniel", 28);
            Console.WriteLine($"The instance with name: {nameof(a)}, has property name: {a.name} and id: {a.id}");
            Console.ReadLine(); ;
        }
    }
}
