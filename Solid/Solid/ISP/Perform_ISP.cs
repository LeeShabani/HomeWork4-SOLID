using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.ISP
{
   public interface IWorkable
    {
        void work();
    }
    public interface IFeedable
    {
        void eat();
    }
    public interface ISleepable
    {
        void sleep();
    }

    public class HumanWorkerr : IWorkable, ISleepable, IFeedable
    {
        public void eat()
        {
            Console.WriteLine("Human Eat");
        }

        public void sleep()
        {
            Console.WriteLine("Human sleep");
        }

        public void work()
        {
            Console.WriteLine("Human work");
        }
    }

    public class RobotWorkerR : IWorkable
    {
        public void work()
        {
            Console.WriteLine("ROBOT JUST  WORK");
        }
    }
}
