using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 Interface Segragation principle:
هیچ کلاینتی نباید مجبور باشه به متد هایی که ازشون استفاده نمیکنه وابسته باشه.
در واقع میگه اینترفیس های بزرگ رو به اینترفیس های کوچک تر بشکونیم

چرا نباید کلاسها مجبور به پیادهسازی متدهایی شوند که از آنها استفاده نمیکنند ؟
وقتی یک اینترفیس بزرگ میسازیم متد هایی که هیچکاری نمیکنند زیاد میشن و این تمیز نیست
وقتی متد ها جاهای زیادی الکی استفاده بشن وابستگی الکی ایجاد میشه و ممکنه با تغییر یک متد توی اینترفیس مشکلاتی پیش بیاد
در واقع با شکوندن این اصل - اصل SRP هم میشکنه
 */
namespace Solid.ISP
{
public interface IWorker
    {
        void work();
        void eat();
        void sleep();
    }

    public class HumanWorker : IWorker
    {
        public void eat()
        {
            Console.WriteLine("Human eat");
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
    // نقص isp
    public class RobotWorker : IWorker
    {
        public void eat()
        {
            Console.WriteLine("ROBOT works ...");
        }

        public void sleep()
        {
            throw new NotImplementedException();
        }

        public void work()
        {
            throw new NotImplementedException();
        }
    }
}
