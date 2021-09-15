/*
 * project = Login into Facebook Using Data Driven FrameWork
 * Author =  sahithi paladi
 * Created Date = 14/09/2021
 */
using NUnit.Framework;
using OpenQA.Selenium;


namespace DataDrivenTestProject.ActionDo
{
    public class ActionsDone
    {
        //Checking the title
        public static void AssertAfterLauching(IWebDriver driver)
        {
            string title1 = "Facebook - లాగిన్ లేదా సైన్ అప్";
            string title = driver.Title;
            Assert.AreEqual(title1, title);
        }

     }
}

