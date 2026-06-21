using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.SRP
{
    /*
     single responsibility principle:
    یعنی هر کلاس باید یک وظیفه داشته باشه و نباید جندین وظیقه رو انجام بده 
    به این منظور نیست که هر کلاس یک متد داشته باشه بلکه منظور اینه اجزایی که به هم دیگه مربوط هستن باید در یک کلاس باشند
     */
    /*
     تو مثال زیر این کلاس چهارتا وظیفه داره که اشتباه هست چون مثلا با تغییر قوانین اعتبار سنجی و یا تغییر روش ذخیره در دیتابیس
    باید این کلاسی رو تغییر بدیم که چهار وظیفه داره
     SRP  است و این نقض 
     */
    public class UserManager
    {
        public void RegisterUser(string username, string email)
        {
            // وظیفه اول :اعتبارسنجی
            if (string.IsNullOrWhiteSpace(username))
                throw new Exception("Username is required.");

            if (string.IsNullOrWhiteSpace(email))
                throw new Exception("Email is required.");

            // وظیفه دوم : ذخیره در دیتابیس
            Console.WriteLine("User saved to database.");

            // وظیفه سوم : ارسال خوش امد گویی
            Console.WriteLine("Welcome email sent.");

            //وظیفه چهارم : ثبت لاگ
            Console.WriteLine("Log written.");
        }
    }

}
