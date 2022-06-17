﻿
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

    [TestFixture]
    [Parallelizable]
    public class TM_Tests : CommonDriver
    {
        // page object initialization

        TMPage tmPageObj = new TMPage();
        Homepage homePageObj = new Homepage();

        [Test, Order(1), Description("Create time and material record with valid data")]
        public void CreateTM()
        {

            // Home page object initialization and definition
            homePageObj.GoToTMpage(driver);

            // TM page object initialization and definition
            tmPageObj.CreateTM(driver);
        }
        [Test, Order(2), Description("Edit time and material record created in test number 1")]
        public void EditTM()
        {
            // Home page object initialization and definition
            homePageObj.GoToTMpage(driver);

            // Edit TM
            tmPageObj.EditTM(driver,"dummy1","dummy2","dummy3");
        }
        [Test, Order(3), Description("Delete time and material record edited in test number 2")]
        public void DeleteTM()
        {
            // Home page object initialization and definition
            homePageObj.GoToTMpage(driver);

            // Delete TM
            tmPageObj.DeleteTM(driver);

        }

    }

}

