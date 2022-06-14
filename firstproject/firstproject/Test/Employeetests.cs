using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using firstproject.Pages;
using firstproject.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace firstproject.Tests
{
    [TestFixture]
    [Parallelizable]
    public class Employee_Tests : CommonDriver
    {
        //Page object initialization

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

        Homepage homepageobj = new Homepage();
        EmployeePage employeePageObj = new EmployeePage();

        [Test, Order(1), Description("Create Employee record with valid data")]


        public void CreateEmployee()

        {
            

            homepageobj.GoToEmployeePage(driver);
            employeePageObj.CreateEmplyee(driver);

        }
        [Test, Order(2), Description("Edit employee record created in test number 1")]
        public void EditEmployee()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            //loginpage object initialization and defintion
            LoginPage loginpageobj = new LoginPage();
            loginpageobj.LoginAction(driver);
            //homepage object initializatio and defintion
            Homepage homepageobj = new Homepage();
            homepageobj.GoToTMpage(driver);
            homepageobj.GoToEmployeePage(driver);
            employeePageObj.EditEmployee(driver);
        }
        [Test, Order(3), Description("Delete employee record created in test number 2")]
        public void DeleteEmployee()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            //loginpage object initialization and defintion
            LoginPage loginpageobj = new LoginPage();
            loginpageobj.LoginAction(driver);
            //homepage object initializatio and defintion
            Homepage homepageobj = new Homepage();
            homepageobj.GoToTMpage(driver);
            homepageobj.GoToEmployeePage(driver);
            employeePageObj.DeleteEmployee(driver);
        }

    }
}