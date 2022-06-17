using firstproject.Pages;
using firstproject.Utilities;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace firstproject.StepDefinition
{
    [Binding]
    public  class TMFeatureDefinitions : CommonDriver
    {
        [Given(@"I logged up turnup portal successfully")]
        public void GivenILoggedUpTurnupPortalSuccessfully()
        {
            // open chrome browser
            driver = new ChromeDriver();

            // Login page object initialization and definition
            LoginPage loginPageObj = new LoginPage();
            loginPageObj.LoginAction(driver);
        }

        [When(@"I navigate time and material page")]
        public void WhenINavigateTimeAndMaterialPage()
        {
            // Home page object initialization and definition
            Homepage homePageObj = new Homepage();

            homePageObj.GoToTMpage(driver);

        }
        [When(@"I create a new time and material record")]
        public void WhenICreateANewTimeAndMaterialRecord()
        {
            TMPage tmPageObj = new TMPage();

            // TM page object initialization and definition
            tmPageObj.CreateTM(driver);
        }
        [Then(@"The record created sucessfully")]
        public void ThenTheRecordCreatedSucessfully()
        {
            TMPage tmPageObj = new TMPage();
            String newCode = tmPageObj.GetnewCode(driver);
            Assert.That(newCode == "test", "Actualcode and Expected Code do not match");
            String newTypeCode = tmPageObj.GetnewTypeCode(driver);
            Assert.That(newTypeCode == "M", "Actual Typecode and Expected Typecode do not match");
            String newDescription = tmPageObj.GetnewDescription(driver);
            Assert.That(newDescription == "automation", "Actual description and Expected description do not match");
           // String newPrice = tmPageObj.GetnewPrice(driver);
            //Assert.That(newPrice == "$12.00", "Actual price and Expected price do not match");
            driver.Close();

        }

        [When(@"I update '([^']*)', '([^']*)','([^']*)' on an existing time and material record")]
        public void WhenIUpdateOnAnExistingTimeAndMaterialRecord(string description, string code,String price)
        {
            TMPage tmPageObj = new TMPage();
            tmPageObj.EditTM(driver,description,code,price);
             
        }

        [Then(@"The record should have updated '([^']*)','([^']*)','([^']*)'")]
        public void ThenTheRecordShouldHaveUpdated(string p0, string p1,String p2)
        {
            TMPage tmPageObj = new TMPage();
            String enewDescription = tmPageObj.geteditDescriptionTM(driver);
            String enewCode=tmPageObj.getEditcodeTM(driver);
            String enewPrice = tmPageObj.getEditedPriceTM(driver);
            Assert.That(enewCode == p1, "actual code expected code do not match ");
            Assert.That(enewDescription == p0, "actual code expected code do not match");
            Assert.That(enewPrice == p2, "actual code expected code do not match");
        }

        [When(@"I Deleted the Existing records using '([^']*)','([^']*)'>")]
        public void WhenIDeletedTheExistingRecordsUsing(String p0)
        {
            TMPage tmPageObj = new TMPage();
            tmPageObj.DeleteTM(driver);
                    }

        [Then(@"The record deleted Successfully")]
        public void ThenTheRecordDeletedSuccessfully()
        {
            TMPage tmPageObj = new TMPage();
            tmPageObj.CodeDeleteAssertion(driver);
            tmPageObj.DescriptionDeleteAssertion(driver);
            tmPageObj.PriceDeleteAssertion(driver);

        }

    }
}
