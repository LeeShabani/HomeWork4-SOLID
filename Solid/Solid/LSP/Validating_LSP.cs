using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 lISKOV SUBSITUTION PRINCIPLE:
اگه یک کلاس فرزند که از کلاس وارد ارث بری میکنه - هرجا که کلاس والد هست رو کلاس فرزند بذاریم کد باید کار کنه مثل قبل
در واقع :
وقتی یک ابسترکشن یا بیس کلاس میسازیم داریم قرار داد تعریف میکنیم
و هر ساب کلاس باید به اون قرار داد  وفادار بمونه.
 */
/*
 مثلا برای کد زیر:
پنگوین کلاس فرزند پرنده هست  - و جز پرندگان هم دسته بندی میشه
ولی اینجا رفتار مهمه و چون پنگوین نمیتونه پرواز کنه پس 
نقض LSP هست .
 */


namespace Solid.LSP
{
    public class Bird
    {
        public virtual void Fly()
        {
            Console.WriteLine("Bird is flying");
        }
    }

    public class Sparrow : Bird
    {
        public override void Fly()
        {
            Console.WriteLine("Sparrow is flying");
        }
    }

    public class Penguin : Bird
    {
        public override void Fly()
        {
            throw new NotSupportedException("Penguins can't fly.");
        }
    }



}
