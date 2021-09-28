using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using September2021.Pages;
using System;
using System.Threading;

namespace September2021
{
    class TM_Tests
    {
        static void Main(string[] args)
        {
            // open chrome browser
            IWebDriver driver = new ChromeDriver();

            // Login page object initialization and definition
            LoginPage loginPageObj = new LoginPage();
            loginPageObj.LoginActions(driver);

            // Home page object initialization and definition
            HomePage homePageObj = new HomePage();
            homePageObj.GoToTMPage(driver);

            // TM page object initialization and definition
            TMPage tmPageObj = new TMPage();
            tmPageObj.CreateTM(driver);


            // Edit time

            tmPageObj.EditTM(driver);

            // Delete time

            tmPageObj.DeleteTM(driver);

        }
    }
}
