/*
 * project = Login into Facebook Using Data Driven FrameWork
 * Author =  sahithi paladi
 * Created Date = 14/09/2021
 */
using DataDrivenTestProject.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using System;

namespace DataDrivenTestProject
{
    public class ReadFromExcelTest : Base.BaseClass
    {
        [Test]
        public void ReadingDataFromExcelAndLoginIntofb()
        {
            ExcelOperations.PopulateInCollection(@"C:\Users\sahithi.p\source\repos\DataDrivenTestProject\DataDrivenTestProject\TestLogin.xlsx");

            LoginPage login = new LoginPage(driver);
            login.email.SendKeys(ExcelOperations.ReadData(1, "Username"));
            System.Threading.Thread.Sleep(2000);
            Console.WriteLine("Username is entered sucessfully");

            login.password.SendKeys(ExcelOperations.ReadData(1, "Password"));
            System.Threading.Thread.Sleep(2000);
            Console.WriteLine("Password is entered sucessfully");

            login.loginButton.Click();
            System.Threading.Thread.Sleep(9000);
            Console.WriteLine("Login into facebook sucessfully");




        }
    }
}
