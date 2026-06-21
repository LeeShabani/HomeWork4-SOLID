using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 Open/Close Principle :
این اصل میگه کلاس ها و ماژول های و بخش های نرم افزار باید برای توسعه باز باشه ولی برای اصلاح بسته
یعنی باید بتونیم قابلیت جدید اضافه کنیم بدون دستکاری کد های قبلی
به زبانی دیگر:
هسته اصلی ثابت بمونه و قابلیت های تازه و جدید از بیرون وصل شن بهش
 */
/*
 مثلا تو مثال پایین اگه بخوایم یک تایپ کارمند جدید اضافه کنیم باید بیایم کلاس اصلی رو اصلاح کنیم 
که این نقض OCP هست 
 */
namespace Solid.OCP
{
    public class SalaryCalculator
    {
        public decimal Calculate(string employeeType, decimal baseSalary)
        {
            if (employeeType == "FullTime")
            {
                return baseSalary + 2000;
            }
            else if (employeeType == "PartTime")
            {
                return baseSalary + 500;
            }
            else if (employeeType == "Contractor")
            {
                return baseSalary;
            }

            throw new ArgumentException("Unknown employee type");
        }
    }

}
