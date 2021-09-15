/*
 * project = Login into Facebook Using Data Driven FrameWork
 * Author = sahithi paladi
 * Created Date = 13/09/2021
 */
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace DataDrivenTestProject.Pages
{
    public class LoginPage
    { 
        //Using page factory
        public LoginPage(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
        }

        public LoginPage()
        {
        }

        [FindsBy(How = How.Name, Using = "email")]
        [CacheLookup]
        public IWebElement email;



        [FindsBy(How = How.Id, Using = "pass")]
        [CacheLookup]
        public IWebElement password;



        [FindsBy(How = How.Name, Using = "login")]
        [CacheLookup]
        public IWebElement loginButton;

    }
}


