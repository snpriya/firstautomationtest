
// See https://aka.ms/new-console-template for more information


using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;
using System;
using firstproject.Pages;

{


    //open chrome browser
    IWebDriver driver = new ChromeDriver();
    driver.Manage().Window.Maximize();
    //loginpage object initialization and defintion
    LoginPage loginpageobj = new LoginPage();
    loginpageobj.LoginAction(driver);
    //homepage object initializatio and defintion
    Homepage homepageobj = new Homepage();
    homepageobj.GoToTMpage(driver);
    //tmpage object initializtion and definition
    TMPage tmpageobj = new TMPage();
    tmpageobj.CreateTM(driver);
    tmpageobj.EditTM(driver);
    tmpageobj.DeleteTM(driver);
}
