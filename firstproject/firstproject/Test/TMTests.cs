
// See https://aka.ms/new-console-template for more information


using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;
using System;
using firstproject.Pages;
using NUnit.Framework;
using firstproject.Utilities;

public class TMTests:CommonDriver
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
        [Test]
        public void CreateTM()
        {
            //tmpage object initializtion and definition
            TMPage tmpageobj = new TMPage();
            tmpageobj.CreateTM(driver, neweCode);
        }
        [Test]
        public void EditTM()
        {
            TMPage tmpageobj = new TMPage();
            tmpageobj.EditTM(driver);
        }
        [Test]
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


    
    
    
    
