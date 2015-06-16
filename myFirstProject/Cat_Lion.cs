using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myFirstProject
{
    class Cat_Lion
    {
        static void Main(string[] args)
        {
            Cat lion = new Lion();
            lion.sound();
            Console.ReadKey();
        }
    }

    class Cat
    {
        public virtual void sound()
        {
            Console.Write("Mauu...");
        }
    }
    class Lion : Cat
    {
        public override void sound(){
            Console.Write("Rrrr...");
        }
    }
}
