using NUnit.Framework;
using OpenQA.Selenium;
using firstproject.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace firstproject.Pages
{
    public class EmployeePage

    {
        public void CreateEmplyee(IWebDriver driver)
        {

            //Click create button
            driver.FindElement(By.XPath("//*[@id='container']/p/a")).Click();
            Thread.Sleep(2000);

            //Send text to name text box
            driver.FindElement(By.Id("Name")).SendKeys("sathya");
            Thread.Sleep(2000);

            //send text to Username text box
            driver.FindElement(By.Id("Username")).SendKeys("sathya25");

            Thread.Sleep(2000);
            //Identify edit contact button and click
            driver.FindElement(By.Id("EditContactButton")).Click();
            Console.WriteLine("Edit Button clicked");
            Thread.Sleep(2000);

            //Navigate to the popup window
            driver.SwitchTo().Frame(0);
            //Enter the details into contact textboxes
            driver.FindElement(By.Id("FirstName")).SendKeys("sathya");

            driver.FindElement(By.Id("LastName")).SendKeys("priya");

            driver.FindElement(By.Id("PreferedName")).SendKeys("sathya");

            driver.FindElement(By.Id("Phone")).SendKeys("0123456");

            driver.FindElement(By.Id("Mobile")).SendKeys("78901011");

            driver.FindElement(By.Id("email")).SendKeys("sathyapriya@gmail.com");

            driver.FindElement(By.Id("Fax")).SendKeys("12345");

            Thread.Sleep(2000);
            //Address
            driver.FindElement(By.Id("Street")).SendKeys("hobson street");

            driver.FindElement(By.Id("City")).SendKeys("auckland");

            driver.FindElement(By.Id("Postcode")).SendKeys("1010");

            driver.FindElement(By.Id("Country")).SendKeys("Newzealand");

            Thread.Sleep(2000);
            // Identify save Button and click
            driver.FindElement(By.Id("submitButton")).Click();
            Console.WriteLine("Contact Edit Saved");
            Thread.Sleep(2000);
            //switch back to window
            driver.SwitchTo().DefaultContent();

            Thread.Sleep(2000);
            //Send text to password textbox
            driver.FindElement(By.Id("Password")).SendKeys("sathya25#");

            Thread.Sleep(2000);
            //Send text to retype password
            driver.FindElement(By.Id("RetypePassword")).SendKeys("sathya25#");

            Thread.Sleep(2000);
            //click Isadmin
            driver.FindElement(By.Id("IsAdmin")).Click();

            Thread.Sleep(3000);
            //Select vehicle textbox enter velicle information
            driver.FindElement(By.XPath("//*[@id='UserEditForm']/div/div[7]/div/span[1]/span/input")).SendKeys("Brand:Nissan, Colour:Red");
            Thread.Sleep(3000);

            //Select Groups Text drop down and click
            driver.FindElement(By.XPath("//*[@id='UserEditForm']/div/div[8]/div/div/div[1]")).Click();
            Thread.Sleep(3000);

            //Select from the Groups options and click
            driver.FindElement(By.XPath("//*[@id='groupList_listbox']/li[14]")).Click();

            Thread.Sleep(2000);
            //Identify save button and click
            driver.FindElement(By.Id("SaveButton")).Click();

            Thread.Sleep(2000);
            //identify back to list and click
            driver.FindElement(By.XPath("//*[@id='container']/div/a")).Click();

            Thread.Sleep(2000);
            //Identify Gotolastpage and click
            driver.FindElement(By.XPath("//*[@id='usersGrid']/div[4]/a[4]/span")).Click();

            // Identify the new employee record created successfuly
            IWebElement newNameTextBox = driver.FindElement(By.XPath("//*[@id='usersGrid']/div[3]/table/tbody/tr[last()]/td[1]"));
            IWebElement newUsernameTextBox = driver.FindElement(By.XPath("//*[@id='usersGrid']/div[3]/table/tbody/tr[last()]/td[2]"));

            // Assert 2
            Assert.That(newNameTextBox.Text == "sathya", "Actual record and expected record do not match.");
            Assert.That(newUsernameTextBox.Text == "sathya25", "Actual record and expected record do not match.");

        }

        public void EditEmployee(IWebDriver driver)
        {
            Thread.Sleep(2000);
            //Identify last page button and click
            driver.FindElement(By.XPath("//*[@id='usersGrid']/div[4]/a[4]/span")).Click();

            Thread.Sleep(2000);
            //Identifying created record and click on edit button
            driver.FindElement(By.XPath("//*[@id='usersGrid']/div[3]/table/tbody/tr[last()]/td[3]/a[1]")).Click();

            Thread.Sleep(2000);
            //Edit text to name text box
            IWebElement editNameBox = driver.FindElement(By.Id("Name"));
            editNameBox.Clear();
            editNameBox.SendKeys("sathya Newedit");
            Thread.Sleep(2000);

            //Edit text to Username text box
            IWebElement editUserNameBox = driver.FindElement(By.Id("Username"));
            editUserNameBox.Clear();
            editUserNameBox.SendKeys("sathya1 Newedit");
            Thread.Sleep(2000);


            Thread.Sleep(2000);
            //Identify edit contact button and click
            driver.FindElement(By.Id("EditContactButton")).Click();
            Console.WriteLine("Edit Button clicked");
            Thread.Sleep(2000);

            //Navigate to the popup window
            driver.SwitchTo().Frame(0);
            //Enter the Edit details into contact textboxes
            IWebElement editFirstnameBox = driver.FindElement(By.Id("FirstName"));
            editFirstnameBox.Click();
            editFirstnameBox.SendKeys("lakshi");

            IWebElement editLastNameBox = driver.FindElement(By.Id("LastName"));
            editLastNameBox.Clear();
            editLastNameBox.SendKeys("Edited");

            IWebElement editPreferedNameBox = driver.FindElement(By.Id("PreferedName"));
            editPreferedNameBox.Clear();
            editPreferedNameBox.SendKeys("lakshi");

            IWebElement editPhoneNumberBox = driver.FindElement(By.Id("Phone"));
            editPhoneNumberBox.Clear();
            editPhoneNumberBox.SendKeys("0423456");

            IWebElement editMobileBox = driver.FindElement(By.Id("Mobile"));
            editMobileBox.Clear();
            editMobileBox.SendKeys("0555341");

            IWebElement editEmailBox = driver.FindElement(By.Id("email"));
            editEmailBox.Clear();
            editEmailBox.SendKeys("lakshi17@gmail.com");

            IWebElement editFaxBox = driver.FindElement(By.Id("Fax"));
            editFaxBox.Clear();
            editFaxBox.SendKeys("4567");

            Thread.Sleep(2000);
            // Edit Address
            IWebElement editStreetBox = driver.FindElement(By.Id("Street"));
            editStreetBox.Clear();
            editStreetBox.SendKeys("nelson Street");

            IWebElement editCityBox = driver.FindElement(By.Id("City"));
            editCityBox.Clear();
            editCityBox.SendKeys("mounteden");

            IWebElement editPostCodeBox = driver.FindElement(By.Id("Postcode"));
            editPostCodeBox.Clear();
            editPostCodeBox.SendKeys("1024");

            IWebElement EditCountryBox = driver.FindElement(By.Id("Country"));
            EditCountryBox.Clear();
            EditCountryBox.SendKeys("Newzealand");

            Thread.Sleep(2000);
            // Identify save Button and click
            driver.FindElement(By.Id("submitButton")).Click();
            Console.WriteLine("Contact Edit Saved");

            Thread.Sleep(2000);
            //switch back to window
            driver.SwitchTo().DefaultContent();

            Thread.Sleep(2000);
            //Edit text to password textbox
            IWebElement editPasswordBox = driver.FindElement(By.Id("Password"));
            editPasswordBox.Clear();
            editPasswordBox.SendKeys("priya123#");

            Thread.Sleep(2000);
            //Edit text to retype password
            IWebElement editRetypePasswordBox = driver.FindElement(By.Id("RetypePassword"));
            editRetypePasswordBox.Clear();
            editRetypePasswordBox.SendKeys("priya123#");

            Thread.Sleep(3000);
            //Select vehicle textbox enter velicle information
            IWebElement editVehicleTextBox = driver.FindElement(By.XPath("//*[@id='UserEditForm']/div/div[7]/div/span[1]/span/input"));
            editVehicleTextBox.Clear();
            editVehicleTextBox.SendKeys("Brand:skoda, Colour:Grey");

            Thread.Sleep(3000);
            //Identify save button and click
            driver.FindElement(By.Id("SaveButton")).Click();

            Thread.Sleep(2000);
            //identify back to list and click
            driver.FindElement(By.XPath("//*[@id='container']/div/a")).Click();

            Thread.Sleep(2000);
            //Identify Gotolastpage and click
            driver.FindElement(By.XPath("//*[@id='usersGrid']/div[4]/a[4]/span")).Click();

            //Identify edited employee record creared successfully
            IWebElement editedName = driver.FindElement(By.XPath("//*[@id='usersGrid']/div[3]/table/tbody/tr[last()]/td[1]"));
            IWebElement editedUserName = driver.FindElement(By.XPath("//*[@id='usersGrid']/div[3]/table/tbody/tr[last()]/td[2]"));

            // Assert 2
            Assert.That(editedName.Text == "sathya Newedit", "Actual record and expected record do not match.");
            Assert.That(editedUserName.Text == "sathya1 Newedit", "Actual record and expected record do not match.");


        }

        public void DeleteEmployee(IWebDriver driver)
        {
            // Identify last page button and click
            Thread.Sleep(1000);
            IWebElement lastPageButton = driver.FindElement(By.XPath("//*[@id='usersGrid']/div[4]/a[4]/span"));
            lastPageButton.Click();
            Thread.Sleep(1000);

            // Identify delete button and click
            IWebElement lastRecord = driver.FindElement(By.XPath("//*[@id='usersGrid']/div[3]/table/tbody/tr[last()]/td[3]/a[2]"));
            lastRecord.Click();

            Thread.Sleep(1000);
            driver.SwitchTo().Alert().Accept();
            Console.WriteLine("Ok button clicked");
            Thread.Sleep(3000);

            // Identify last page button and click
            IWebElement lastPageButton1 = driver.FindElement(By.XPath("//*[@id='usersGrid']/div[4]/a[4]/span"));
            lastPageButton1.Click();
            Thread.Sleep(3000);
            //Check the edited record is deleted
            IWebElement theLastRecord = driver.FindElement(By.XPath("//*[@id='usersGrid']/div[3]/table/tbody/tr[last()]/td[1]"));
            Thread.Sleep(2000);

            // Assertion
            Assert.That(theLastRecord.Text != "sathya1 Newedit", "Employee record has not been deleted successfully.");

        }
    }
}
