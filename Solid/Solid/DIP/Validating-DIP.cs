using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 Dependency Inversion Principle : 
اصل وارونگی وابستگی میگه:
ماژول های سطح بالا نباید به ماژول های سطح پایین وابسته باشند
هردو باید به ابسترکت ها وابسته باشن
ابسترکت ها نباید به جزییات وابسته باشند
جزییات باید به ابسترکت های وابسته باشند
 */

/*
 تو مثال پایین
NoticationService : یک ماژول سطح بالا است
EmailSender : یک ماژول سطح پایین است
مشکل:
اگه بخوایم فردا سرویس sms اضافه کنیم باید ماژول سطح بالا رو تغییر بدیم
تست پذیری میاد پایین
و توسعه پذیری سخت تر میشود
 */
namespace Solid.DIP
{
    public class EmailSender
    {
        public void Send(string to, string message)
        {
            Console.WriteLine($"Email sent to {to}: {message}");
        }
    }

    public class NotificationService
    {
        private readonly EmailSender _emailSender = new EmailSender();

        public void Notify(string to, string message)
        {
            _emailSender.Send(to, message);
        }
    }

}
