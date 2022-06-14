
// See https://aka.ms/new-console-template for more information


using firstproject.Pages;
using firstproject.Utilities;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;

namespace firstproject
{
   // public static void main()
    //{ 
    [TestFixture]
    [Parallelizable]

    public class TMTests : CommonDriver
    {

        //open chrome browser
        [SetUp]
        public void LoginAction()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            //loginpage object initialization and defintion
            LoginPage loginpageobj = new LoginPage();
            loginpageobj.LoginAction(driver);
            //homepage object initializatio and defintion
            Homepage homepageobj = new Homepage();
            homepageobj.GoToTMpage(driver);
        }
        [Test, Order(1), Description("Create Time and Material record with valid data")]
        public void CreateTM()
        {
            //tmpage object initializtion and definition
            TMPage tmpageobj = new TMPage();
            tmpageobj.CreateTM(driver);
        }
        [Test, Order(2), Description("EditTM time record created in test number 1")]
        public void EditTM()
        {
            TMPage tmpageobj = new TMPage();
            tmpageobj.EditTM(driver);
        }
        [Test, Order(3), Description("DeleteTM time record created in test number 2")]
        public void DeleteTM()
        {
            TMPage tmpageobj = new TMPage();
            tmpageobj.DeleteTM(driver);
        }
        [TearDown]
        public void CloseTestRun()
        {

        }
    }
}


    
   // }
    
