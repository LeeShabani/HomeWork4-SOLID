using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.LSP.P
{
    // بین همه پرنده ها مشترکه
    public abstract class Bird 
    {
        public string Name { get; set; } = string.Empty;
    }

    // فقط برای پرنده هایی که پروازن
    public interface IFlyingBird
    {
        void Fly();
    }

    public class Sparrow : Bird, IFlyingBird
    {
        public void Fly()
        {
            Console.WriteLine("Sparrow is flying");
        }
    }

    public class Penguin : Bird
    {
        public void Swim()
        {
            Console.WriteLine("Penguin is swimming");
        }
    }

}
